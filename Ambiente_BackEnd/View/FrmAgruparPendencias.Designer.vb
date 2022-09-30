<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgruparPendencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgruparPendencias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtperiodo = New System.Windows.Forms.MaskedTextBox()
        Me.txtate = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAgrupar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPesqusiar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.imgSelecionaProduto = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbItensEcontrados = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgVales = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CODDEBITODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODORCAMENTODataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODABERTURADataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAOSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEBITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.dgMovimentoItem = New System.Windows.Forms.DataGridView()
        Me.CODORCAMENTODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODABERTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOVENDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOBARRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEBITOITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente1 = New Ambiente_BackEnd.dsAmbiente()
        Me.VENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.teste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CODDEBITODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODORCAMENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODABERTURADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.imgSelecionaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbItensEcontrados.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMovimentoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBITOITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtperiodo
        '
        Me.txtperiodo.Location = New System.Drawing.Point(81, 79)
        Me.txtperiodo.Mask = "00/00/0000"
        Me.txtperiodo.Name = "txtperiodo"
        Me.txtperiodo.Size = New System.Drawing.Size(109, 20)
        Me.txtperiodo.TabIndex = 254
        Me.txtperiodo.ValidatingType = GetType(Date)
        '
        'txtate
        '
        Me.txtate.Location = New System.Drawing.Point(316, 79)
        Me.txtate.Mask = "00/00/0000"
        Me.txtate.Name = "txtate"
        Me.txtate.Size = New System.Drawing.Size(109, 20)
        Me.txtate.TabIndex = 255
        Me.txtate.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Até:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 252
        Me.Label3.Text = "Período:"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Enabled = False
        Me.txtNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCliente.Location = New System.Drawing.Point(189, 51)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(236, 22)
        Me.txtNomeCliente.TabIndex = 251
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Cliente:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(81, 51)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(107, 22)
        Me.txtCodigoCliente.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agrupamento de Vales"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 45)
        Me.Panel1.TabIndex = 247
        '
        'btnSair
        '
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(888, 0)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(130, 51)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(637, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(85, 51)
        Me.Panel5.TabIndex = 5
        '
        'btnAgrupar
        '
        Me.btnAgrupar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgrupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgrupar.Image = CType(resources.GetObject("btnAgrupar.Image"), System.Drawing.Image)
        Me.btnAgrupar.Location = New System.Drawing.Point(426, 0)
        Me.btnAgrupar.Name = "btnAgrupar"
        Me.btnAgrupar.Size = New System.Drawing.Size(211, 51)
        Me.btnAgrupar.TabIndex = 4
        Me.btnAgrupar.Text = "Agrupar Selecionados"
        Me.btnAgrupar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgrupar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgrupar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(343, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(83, 51)
        Me.Panel4.TabIndex = 3
        '
        'btnPesqusiar
        '
        Me.btnPesqusiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPesqusiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesqusiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesqusiar.Image = CType(resources.GetObject("btnPesqusiar.Image"), System.Drawing.Image)
        Me.btnPesqusiar.Location = New System.Drawing.Point(213, 0)
        Me.btnPesqusiar.Name = "btnPesqusiar"
        Me.btnPesqusiar.Size = New System.Drawing.Size(130, 51)
        Me.btnPesqusiar.TabIndex = 2
        Me.btnPesqusiar.Text = "Pesquisar"
        Me.btnPesqusiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesqusiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesqusiar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(130, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(83, 51)
        Me.Panel3.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 51)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'imgSelecionaProduto
        '
        Me.imgSelecionaProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgSelecionaProduto.Image = CType(resources.GetObject("imgSelecionaProduto.Image"), System.Drawing.Image)
        Me.imgSelecionaProduto.Location = New System.Drawing.Point(427, 51)
        Me.imgSelecionaProduto.Name = "imgSelecionaProduto"
        Me.imgSelecionaProduto.Size = New System.Drawing.Size(32, 21)
        Me.imgSelecionaProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSelecionaProduto.TabIndex = 250
        Me.imgSelecionaProduto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnAgrupar)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnPesqusiar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 459)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 51)
        Me.Panel2.TabIndex = 246
        '
        'tbItensEcontrados
        '
        Me.tbItensEcontrados.Controls.Add(Me.TabPage1)
        Me.tbItensEcontrados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbItensEcontrados.Location = New System.Drawing.Point(0, 106)
        Me.tbItensEcontrados.Name = "tbItensEcontrados"
        Me.tbItensEcontrados.SelectedIndex = 0
        Me.tbItensEcontrados.Size = New System.Drawing.Size(1018, 353)
        Me.tbItensEcontrados.TabIndex = 256
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgVales)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Itens Encontrados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgVales
        '
        Me.dgVales.AllowUserToAddRows = False
        Me.dgVales.AllowUserToDeleteRows = False
        Me.dgVales.AllowUserToOrderColumns = True
        Me.dgVales.AllowUserToResizeColumns = False
        Me.dgVales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgVales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVales.AutoGenerateColumns = False
        Me.dgVales.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.CODDEBITODataGridViewTextBoxColumn1, Me.CODORCAMENTODataGridViewTextBoxColumn3, Me.CODABERTURADataGridViewTextBoxColumn3, Me.CODCAIXADataGridViewTextBoxColumn2, Me.CODCLIENTEDataGridViewTextBoxColumn, Me.RAZAOSOCIALDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.dgVales.DataSource = Me.DEBITOBindingSource
        Me.dgVales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVales.GridColor = System.Drawing.Color.White
        Me.dgVales.Location = New System.Drawing.Point(3, 3)
        Me.dgVales.Name = "dgVales"
        Me.dgVales.Size = New System.Drawing.Size(1004, 321)
        Me.dgVales.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'CODDEBITODataGridViewTextBoxColumn1
        '
        Me.CODDEBITODataGridViewTextBoxColumn1.DataPropertyName = "CODDEBITO"
        Me.CODDEBITODataGridViewTextBoxColumn1.HeaderText = "Codigo Debito"
        Me.CODDEBITODataGridViewTextBoxColumn1.Name = "CODDEBITODataGridViewTextBoxColumn1"
        '
        'CODORCAMENTODataGridViewTextBoxColumn3
        '
        Me.CODORCAMENTODataGridViewTextBoxColumn3.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn3.HeaderText = "Codigo Orcamento"
        Me.CODORCAMENTODataGridViewTextBoxColumn3.Name = "CODORCAMENTODataGridViewTextBoxColumn3"
        Me.CODORCAMENTODataGridViewTextBoxColumn3.Width = 120
        '
        'CODABERTURADataGridViewTextBoxColumn3
        '
        Me.CODABERTURADataGridViewTextBoxColumn3.DataPropertyName = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn3.HeaderText = "Codigo Abertura"
        Me.CODABERTURADataGridViewTextBoxColumn3.Name = "CODABERTURADataGridViewTextBoxColumn3"
        Me.CODABERTURADataGridViewTextBoxColumn3.Width = 120
        '
        'CODCAIXADataGridViewTextBoxColumn2
        '
        Me.CODCAIXADataGridViewTextBoxColumn2.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn2.HeaderText = "Caixa"
        Me.CODCAIXADataGridViewTextBoxColumn2.Name = "CODCAIXADataGridViewTextBoxColumn2"
        Me.CODCAIXADataGridViewTextBoxColumn2.Width = 70
        '
        'CODCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODCLIENTE"
        Me.CODCLIENTEDataGridViewTextBoxColumn.HeaderText = "Codigo Cliente"
        Me.CODCLIENTEDataGridViewTextBoxColumn.Name = "CODCLIENTEDataGridViewTextBoxColumn"
        '
        'RAZAOSOCIALDataGridViewTextBoxColumn
        '
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAOSOCIAL"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "Razao Social"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.Name = "RAZAOSOCIALDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTALDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.Width = 130
        '
        'DEBITOBindingSource
        '
        Me.DEBITOBindingSource.DataMember = "DEBITO"
        Me.DEBITOBindingSource.DataSource = Me.DsAmbiente
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgMovimentoItem
        '
        Me.dgMovimentoItem.AutoGenerateColumns = False
        Me.dgMovimentoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimentoItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODORCAMENTODataGridViewTextBoxColumn1, Me.CODABERTURADataGridViewTextBoxColumn, Me.CODCAIXADataGridViewTextBoxColumn1, Me.QUANTIDADEDataGridViewTextBoxColumn, Me.PRECOVENDADataGridViewTextBoxColumn, Me.TOTALITEMDataGridViewTextBoxColumn, Me.CODIGOBARRADataGridViewTextBoxColumn})
        Me.dgMovimentoItem.DataSource = Me.DEBITOITEMBindingSource
        Me.dgMovimentoItem.Location = New System.Drawing.Point(557, 51)
        Me.dgMovimentoItem.Name = "dgMovimentoItem"
        Me.dgMovimentoItem.Size = New System.Drawing.Size(457, 71)
        Me.dgMovimentoItem.TabIndex = 270
        Me.dgMovimentoItem.Visible = False
        '
        'CODORCAMENTODataGridViewTextBoxColumn1
        '
        Me.CODORCAMENTODataGridViewTextBoxColumn1.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn1.HeaderText = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn1.Name = "CODORCAMENTODataGridViewTextBoxColumn1"
        '
        'CODABERTURADataGridViewTextBoxColumn
        '
        Me.CODABERTURADataGridViewTextBoxColumn.DataPropertyName = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn.HeaderText = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn.Name = "CODABERTURADataGridViewTextBoxColumn"
        '
        'CODCAIXADataGridViewTextBoxColumn1
        '
        Me.CODCAIXADataGridViewTextBoxColumn1.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn1.HeaderText = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn1.Name = "CODCAIXADataGridViewTextBoxColumn1"
        '
        'QUANTIDADEDataGridViewTextBoxColumn
        '
        Me.QUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE"
        Me.QUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE"
        Me.QUANTIDADEDataGridViewTextBoxColumn.Name = "QUANTIDADEDataGridViewTextBoxColumn"
        '
        'PRECOVENDADataGridViewTextBoxColumn
        '
        Me.PRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECO_VENDA"
        Me.PRECOVENDADataGridViewTextBoxColumn.HeaderText = "PRECO_VENDA"
        Me.PRECOVENDADataGridViewTextBoxColumn.Name = "PRECOVENDADataGridViewTextBoxColumn"
        '
        'TOTALITEMDataGridViewTextBoxColumn
        '
        Me.TOTALITEMDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_ITEM"
        Me.TOTALITEMDataGridViewTextBoxColumn.HeaderText = "TOTAL_ITEM"
        Me.TOTALITEMDataGridViewTextBoxColumn.Name = "TOTALITEMDataGridViewTextBoxColumn"
        '
        'CODIGOBARRADataGridViewTextBoxColumn
        '
        Me.CODIGOBARRADataGridViewTextBoxColumn.DataPropertyName = "CODIGOBARRA"
        Me.CODIGOBARRADataGridViewTextBoxColumn.HeaderText = "CODIGOBARRA"
        Me.CODIGOBARRADataGridViewTextBoxColumn.Name = "CODIGOBARRADataGridViewTextBoxColumn"
        '
        'DEBITOITEMBindingSource
        '
        Me.DEBITOITEMBindingSource.DataMember = "DEBITO_ITEM"
        Me.DEBITOITEMBindingSource.DataSource = Me.DsAmbiente1
        '
        'DsAmbiente1
        '
        Me.DsAmbiente1.DataSetName = "dsAmbiente"
        Me.DsAmbiente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENDABindingSource
        '
        Me.VENDABindingSource.DataMember = "VENDA"
        '
        'teste
        '
        Me.teste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.teste.HeaderText = ""
        Me.teste.Name = "teste"
        Me.teste.Width = 40
        '
        'CODDEBITODataGridViewTextBoxColumn
        '
        Me.CODDEBITODataGridViewTextBoxColumn.DataPropertyName = "CODDEBITO"
        Me.CODDEBITODataGridViewTextBoxColumn.HeaderText = "Codigo Debito"
        Me.CODDEBITODataGridViewTextBoxColumn.Name = "CODDEBITODataGridViewTextBoxColumn"
        '
        'CODORCAMENTODataGridViewTextBoxColumn
        '
        Me.CODORCAMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODORCAMENTODataGridViewTextBoxColumn.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn.HeaderText = "Codigo Orçamento"
        Me.CODORCAMENTODataGridViewTextBoxColumn.Name = "CODORCAMENTODataGridViewTextBoxColumn"
        Me.CODORCAMENTODataGridViewTextBoxColumn.Width = 125
        '
        'CODABERTURADataGridViewTextBoxColumn1
        '
        Me.CODABERTURADataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODABERTURADataGridViewTextBoxColumn1.DataPropertyName = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn1.HeaderText = "Codigo Abertura"
        Me.CODABERTURADataGridViewTextBoxColumn1.Name = "CODABERTURADataGridViewTextBoxColumn1"
        Me.CODABERTURADataGridViewTextBoxColumn1.Width = 120
        '
        'CODCAIXADataGridViewTextBoxColumn
        '
        Me.CODCAIXADataGridViewTextBoxColumn.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn.HeaderText = "Caixa"
        Me.CODCAIXADataGridViewTextBoxColumn.Name = "CODCAIXADataGridViewTextBoxColumn"
        '
        'FrmAgruparPendencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 510)
        Me.Controls.Add(Me.dgMovimentoItem)
        Me.Controls.Add(Me.tbItensEcontrados)
        Me.Controls.Add(Me.txtperiodo)
        Me.Controls.Add(Me.txtate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgSelecionaProduto)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmAgruparPendencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgruparPendencias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgSelecionaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tbItensEcontrados.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMovimentoItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBITOITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtperiodo As MaskedTextBox
    Friend WithEvents txtate As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSair As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAgrupar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPesqusiar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents imgSelecionaProduto As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbItensEcontrados As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgVales As DataGridView
    Friend WithEvents dgMovimentoItem As DataGridView
    Friend WithEvents VENDABindingSource As BindingSource
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents CODDEBITODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CODORCAMENTODataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CODABERTURADataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CODCLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAZAOSOCIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEBITOBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents teste As DataGridViewCheckBoxColumn
    Friend WithEvents CODDEBITODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODORCAMENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODABERTURADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODORCAMENTODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CODABERTURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QUANTIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECOVENDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOBARRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEBITOITEMBindingSource As BindingSource
    Friend WithEvents DsAmbiente1 As dsAmbiente
End Class
