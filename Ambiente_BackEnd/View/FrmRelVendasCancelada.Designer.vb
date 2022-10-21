<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelVendasCancelada
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelVendasCancelada))
        Me.cbxTipoCartao = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbItensEcontrados = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgProdutosVendidos = New System.Windows.Forms.DataGridView()
        Me.CODMOVIMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODVENDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVOCANCEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMAPAGTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALMOVIMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCELADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoFormaPagto = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPesqusiar = New System.Windows.Forms.Button()
        Me.cbxFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtperiodo = New System.Windows.Forms.MaskedTextBox()
        Me.txtate = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbItensEcontrados.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProdutosVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxTipoCartao
        '
        Me.cbxTipoCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoCartao.FormattingEnabled = True
        Me.cbxTipoCartao.Items.AddRange(New Object() {"Debito", "Credito"})
        Me.cbxTipoCartao.Location = New System.Drawing.Point(117, 109)
        Me.cbxTipoCartao.Name = "cbxTipoCartao"
        Me.cbxTipoCartao.Size = New System.Drawing.Size(107, 21)
        Me.cbxTipoCartao.TabIndex = 272
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(900, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total: "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(972, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 25)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "...."
        '
        'tbItensEcontrados
        '
        Me.tbItensEcontrados.Controls.Add(Me.TabPage1)
        Me.tbItensEcontrados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbItensEcontrados.Location = New System.Drawing.Point(0, 197)
        Me.tbItensEcontrados.Name = "tbItensEcontrados"
        Me.tbItensEcontrados.SelectedIndex = 0
        Me.tbItensEcontrados.Size = New System.Drawing.Size(1008, 291)
        Me.tbItensEcontrados.TabIndex = 270
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProdutosVendidos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Itens Encontrados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgProdutosVendidos
        '
        Me.dgProdutosVendidos.AllowUserToAddRows = False
        Me.dgProdutosVendidos.AllowUserToDeleteRows = False
        Me.dgProdutosVendidos.AllowUserToOrderColumns = True
        Me.dgProdutosVendidos.AllowUserToResizeColumns = False
        Me.dgProdutosVendidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgProdutosVendidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProdutosVendidos.AutoGenerateColumns = False
        Me.dgProdutosVendidos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProdutosVendidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgProdutosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProdutosVendidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODMOVIMENTO, Me.CODVENDADataGridViewTextBoxColumn, Me.OPERADOR, Me.CODCAIXADataGridViewTextBoxColumn, Me.DATADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.MOTIVOCANCEL, Me.FORMAPAGTODataGridViewTextBoxColumn, Me.TOTALMOVIMENTO, Me.CANCELADA})
        Me.dgProdutosVendidos.DataSource = Me.VENDABindingSource
        Me.dgProdutosVendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProdutosVendidos.GridColor = System.Drawing.Color.White
        Me.dgProdutosVendidos.Location = New System.Drawing.Point(3, 3)
        Me.dgProdutosVendidos.Name = "dgProdutosVendidos"
        Me.dgProdutosVendidos.Size = New System.Drawing.Size(994, 259)
        Me.dgProdutosVendidos.TabIndex = 1
        '
        'CODMOVIMENTO
        '
        Me.CODMOVIMENTO.DataPropertyName = "CODMOVIMENTO"
        Me.CODMOVIMENTO.HeaderText = "Codigo Movimento"
        Me.CODMOVIMENTO.Name = "CODMOVIMENTO"
        Me.CODMOVIMENTO.Width = 120
        '
        'CODVENDADataGridViewTextBoxColumn
        '
        Me.CODVENDADataGridViewTextBoxColumn.DataPropertyName = "CODVENDA"
        Me.CODVENDADataGridViewTextBoxColumn.HeaderText = "Codigo Venda"
        Me.CODVENDADataGridViewTextBoxColumn.Name = "CODVENDADataGridViewTextBoxColumn"
        '
        'OPERADOR
        '
        Me.OPERADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OPERADOR.DataPropertyName = "OPERADOR"
        Me.OPERADOR.HeaderText = "Vendedor"
        Me.OPERADOR.Name = "OPERADOR"
        Me.OPERADOR.Width = 120
        '
        'CODCAIXADataGridViewTextBoxColumn
        '
        Me.CODCAIXADataGridViewTextBoxColumn.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn.HeaderText = "Caixa"
        Me.CODCAIXADataGridViewTextBoxColumn.Name = "CODCAIXADataGridViewTextBoxColumn"
        Me.CODCAIXADataGridViewTextBoxColumn.Width = 60
        '
        'DATADataGridViewTextBoxColumn
        '
        Me.DATADataGridViewTextBoxColumn.DataPropertyName = "DATA"
        Me.DATADataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DATADataGridViewTextBoxColumn.Name = "DATADataGridViewTextBoxColumn"
        Me.DATADataGridViewTextBoxColumn.Width = 80
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.Width = 80
        '
        'MOTIVOCANCEL
        '
        Me.MOTIVOCANCEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MOTIVOCANCEL.DataPropertyName = "MOTIVOCANCEL"
        Me.MOTIVOCANCEL.HeaderText = "Motivo Cancel"
        Me.MOTIVOCANCEL.Name = "MOTIVOCANCEL"
        Me.MOTIVOCANCEL.Width = 160
        '
        'FORMAPAGTODataGridViewTextBoxColumn
        '
        Me.FORMAPAGTODataGridViewTextBoxColumn.DataPropertyName = "FORMAPAGTO"
        Me.FORMAPAGTODataGridViewTextBoxColumn.HeaderText = "Forma Pagamento"
        Me.FORMAPAGTODataGridViewTextBoxColumn.Name = "FORMAPAGTODataGridViewTextBoxColumn"
        Me.FORMAPAGTODataGridViewTextBoxColumn.Width = 120
        '
        'TOTALMOVIMENTO
        '
        Me.TOTALMOVIMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOTALMOVIMENTO.DataPropertyName = "TOTALMOVIMENTO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTALMOVIMENTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTALMOVIMENTO.HeaderText = "Total Movimento"
        Me.TOTALMOVIMENTO.Name = "TOTALMOVIMENTO"
        '
        'CANCELADA
        '
        Me.CANCELADA.DataPropertyName = "CANCELADA"
        Me.CANCELADA.HeaderText = "CANCELADA"
        Me.CANCELADA.Name = "CANCELADA"
        Me.CANCELADA.Visible = False
        '
        'VENDABindingSource
        '
        Me.VENDABindingSource.DataMember = "VENDA"
        Me.VENDABindingSource.DataSource = Me.DsAmbiente
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.lblTotal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 488)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1008, 39)
        Me.Panel6.TabIndex = 269
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 271
        Me.Label7.Text = "Debito / Credito:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-pesquisar.gif")
        Me.ImageList1.Images.SetKeyName(1, "icons8-pesquisar (1).gif")
        '
        'cbxTipo
        '
        Me.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Orçamento", "Venda"})
        Me.cbxTipo.Location = New System.Drawing.Point(117, 79)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(107, 21)
        Me.cbxTipo.TabIndex = 267
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 266
        Me.Label6.Text = "Tipo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Forma Pagto :"
        '
        'txtCodigoFormaPagto
        '
        Me.txtCodigoFormaPagto.Enabled = False
        Me.txtCodigoFormaPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoFormaPagto.Location = New System.Drawing.Point(117, 51)
        Me.txtCodigoFormaPagto.Name = "txtCodigoFormaPagto"
        Me.txtCodigoFormaPagto.Size = New System.Drawing.Size(107, 22)
        Me.txtCodigoFormaPagto.TabIndex = 264
        '
        'btnSair
        '
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(878, 0)
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
        Me.Panel5.Location = New System.Drawing.Point(762, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(116, 51)
        Me.Panel5.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(632, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 51)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(450, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(182, 51)
        Me.Panel4.TabIndex = 3
        '
        'btnPesqusiar
        '
        Me.btnPesqusiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPesqusiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesqusiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesqusiar.Image = CType(resources.GetObject("btnPesqusiar.Image"), System.Drawing.Image)
        Me.btnPesqusiar.Location = New System.Drawing.Point(320, 0)
        Me.btnPesqusiar.Name = "btnPesqusiar"
        Me.btnPesqusiar.Size = New System.Drawing.Size(130, 51)
        Me.btnPesqusiar.TabIndex = 2
        Me.btnPesqusiar.Text = "Pesquisar"
        Me.btnPesqusiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesqusiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesqusiar.UseVisualStyleBackColor = True
        '
        'cbxFormaPagamento
        '
        Me.cbxFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFormaPagamento.FormattingEnabled = True
        Me.cbxFormaPagamento.Location = New System.Drawing.Point(230, 51)
        Me.cbxFormaPagamento.Name = "cbxFormaPagamento"
        Me.cbxFormaPagamento.Size = New System.Drawing.Size(205, 21)
        Me.cbxFormaPagamento.TabIndex = 268
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(130, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 51)
        Me.Panel3.TabIndex = 1
        '
        'txtperiodo
        '
        Me.txtperiodo.Location = New System.Drawing.Point(115, 142)
        Me.txtperiodo.Mask = "00/00/0000"
        Me.txtperiodo.Name = "txtperiodo"
        Me.txtperiodo.Size = New System.Drawing.Size(109, 20)
        Me.txtperiodo.TabIndex = 262
        Me.txtperiodo.ValidatingType = GetType(Date)
        '
        'txtate
        '
        Me.txtate.Location = New System.Drawing.Point(326, 143)
        Me.txtate.Mask = "00/00/0000"
        Me.txtate.Name = "txtate"
        Me.txtate.Size = New System.Drawing.Size(109, 20)
        Me.txtate.TabIndex = 263
        Me.txtate.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "Até:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "Período:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 45)
        Me.Panel1.TabIndex = 259
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(644, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rel. Orçamentos/Vendas Canceladas"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnPesqusiar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 51)
        Me.Panel2.TabIndex = 258
        '
        'FrmRelVendasCancelada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 578)
        Me.Controls.Add(Me.cbxTipoCartao)
        Me.Controls.Add(Me.tbItensEcontrados)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigoFormaPagto)
        Me.Controls.Add(Me.cbxFormaPagamento)
        Me.Controls.Add(Me.txtperiodo)
        Me.Controls.Add(Me.txtate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRelVendasCancelada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRelVendasCancelada"
        Me.tbItensEcontrados.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgProdutosVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxTipoCartao As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbItensEcontrados As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgProdutosVendidos As DataGridView
    Friend WithEvents VENDABindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigoFormaPagto As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPesqusiar As Button
    Friend WithEvents cbxFormaPagamento As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtperiodo As MaskedTextBox
    Friend WithEvents txtate As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CODMOVIMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CODVENDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPERADOR As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOTIVOCANCEL As DataGridViewTextBoxColumn
    Friend WithEvents FORMAPAGTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALMOVIMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CANCELADA As DataGridViewTextBoxColumn
End Class
