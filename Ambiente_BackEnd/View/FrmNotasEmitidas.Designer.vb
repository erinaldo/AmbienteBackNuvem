<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotasEmitidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasEmitidas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbItensEcontrados = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgProdutosVendidos = New System.Windows.Forms.DataGridView()
        Me.NOTAFISCALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPesqusiar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtperiodo = New System.Windows.Forms.MaskedTextBox()
        Me.txtate = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.INSERIRNOTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUMNOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCFOPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFORMAPAGTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLABORADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALNFEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVisualizar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnviarEmail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tbItensEcontrados.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProdutosVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTAFISCALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(749, 0)
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
        Me.lblTotal.Location = New System.Drawing.Point(821, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 25)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "...."
        '
        'tbItensEcontrados
        '
        Me.tbItensEcontrados.Controls.Add(Me.TabPage1)
        Me.tbItensEcontrados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbItensEcontrados.Location = New System.Drawing.Point(0, 111)
        Me.tbItensEcontrados.Name = "tbItensEcontrados"
        Me.tbItensEcontrados.SelectedIndex = 0
        Me.tbItensEcontrados.Size = New System.Drawing.Size(857, 310)
        Me.tbItensEcontrados.TabIndex = 270
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProdutosVendidos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 284)
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
        Me.dgProdutosVendidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMNOTADataGridViewTextBoxColumn, Me.CODCFOPDataGridViewTextBoxColumn, Me.CODFORMAPAGTODataGridViewTextBoxColumn, Me.COLABORADOR, Me.TOTALNFEDataGridViewTextBoxColumn, Me.STATUS, Me.btnVisualizar, Me.btnEnviarEmail})
        Me.dgProdutosVendidos.DataSource = Me.NOTAFISCALBindingSource
        Me.dgProdutosVendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProdutosVendidos.GridColor = System.Drawing.Color.White
        Me.dgProdutosVendidos.Location = New System.Drawing.Point(3, 3)
        Me.dgProdutosVendidos.Name = "dgProdutosVendidos"
        Me.dgProdutosVendidos.Size = New System.Drawing.Size(843, 278)
        Me.dgProdutosVendidos.TabIndex = 1
        '
        'NOTAFISCALBindingSource
        '
        Me.NOTAFISCALBindingSource.DataMember = "NOTAFISCAL"
        Me.NOTAFISCALBindingSource.DataSource = Me.DsAmbiente
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
        Me.Panel6.Location = New System.Drawing.Point(0, 421)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(857, 39)
        Me.Panel6.TabIndex = 269
        '
        'btnSair
        '
        Me.btnSair.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(727, 0)
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
        Me.Panel5.Location = New System.Drawing.Point(614, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(112, 51)
        Me.Panel5.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(484, 0)
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
        Me.Panel4.Location = New System.Drawing.Point(372, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(112, 51)
        Me.Panel4.TabIndex = 3
        '
        'btnPesqusiar
        '
        Me.btnPesqusiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPesqusiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesqusiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesqusiar.Image = CType(resources.GetObject("btnPesqusiar.Image"), System.Drawing.Image)
        Me.btnPesqusiar.Location = New System.Drawing.Point(242, 0)
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
        Me.Panel3.Size = New System.Drawing.Size(112, 51)
        Me.Panel3.TabIndex = 1
        '
        'txtperiodo
        '
        Me.txtperiodo.Location = New System.Drawing.Point(111, 75)
        Me.txtperiodo.Mask = "00/00/0000"
        Me.txtperiodo.Name = "txtperiodo"
        Me.txtperiodo.Size = New System.Drawing.Size(109, 20)
        Me.txtperiodo.TabIndex = 262
        Me.txtperiodo.ValidatingType = GetType(Date)
        '
        'txtate
        '
        Me.txtate.Location = New System.Drawing.Point(322, 76)
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
        Me.Label5.Location = New System.Drawing.Point(285, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "Até:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 76)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 45)
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
        Me.Label1.Size = New System.Drawing.Size(344, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rel. Notas Emitidas"
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
        Me.Panel2.Location = New System.Drawing.Point(0, 460)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 51)
        Me.Panel2.TabIndex = 258
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERIRNOTAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 24)
        Me.MenuStrip1.TabIndex = 271
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'INSERIRNOTAToolStripMenuItem
        '
        Me.INSERIRNOTAToolStripMenuItem.Name = "INSERIRNOTAToolStripMenuItem"
        Me.INSERIRNOTAToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.INSERIRNOTAToolStripMenuItem.Text = "INSERIR NOTA"
        '
        'NUMNOTADataGridViewTextBoxColumn
        '
        Me.NUMNOTADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NUMNOTADataGridViewTextBoxColumn.DataPropertyName = "NUMNOTA"
        Me.NUMNOTADataGridViewTextBoxColumn.HeaderText = "N. Nota"
        Me.NUMNOTADataGridViewTextBoxColumn.Name = "NUMNOTADataGridViewTextBoxColumn"
        Me.NUMNOTADataGridViewTextBoxColumn.Width = 70
        '
        'CODCFOPDataGridViewTextBoxColumn
        '
        Me.CODCFOPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCFOPDataGridViewTextBoxColumn.DataPropertyName = "CODCFOP"
        Me.CODCFOPDataGridViewTextBoxColumn.HeaderText = "Cfop"
        Me.CODCFOPDataGridViewTextBoxColumn.Name = "CODCFOPDataGridViewTextBoxColumn"
        Me.CODCFOPDataGridViewTextBoxColumn.Width = 55
        '
        'CODFORMAPAGTODataGridViewTextBoxColumn
        '
        Me.CODFORMAPAGTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODFORMAPAGTODataGridViewTextBoxColumn.DataPropertyName = "CODFORMAPAGTO"
        Me.CODFORMAPAGTODataGridViewTextBoxColumn.HeaderText = "Forma Pagto"
        Me.CODFORMAPAGTODataGridViewTextBoxColumn.Name = "CODFORMAPAGTODataGridViewTextBoxColumn"
        Me.CODFORMAPAGTODataGridViewTextBoxColumn.Width = 95
        '
        'COLABORADOR
        '
        Me.COLABORADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COLABORADOR.DataPropertyName = "COLABORADOR"
        Me.COLABORADOR.HeaderText = "Razao Social"
        Me.COLABORADOR.Name = "COLABORADOR"
        '
        'TOTALNFEDataGridViewTextBoxColumn
        '
        Me.TOTALNFEDataGridViewTextBoxColumn.DataPropertyName = "TOTALNFE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTALNFEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTALNFEDataGridViewTextBoxColumn.HeaderText = "Total "
        Me.TOTALNFEDataGridViewTextBoxColumn.Name = "TOTALNFEDataGridViewTextBoxColumn"
        '
        'STATUS
        '
        Me.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STATUS.DataPropertyName = "STATUS"
        Me.STATUS.HeaderText = "Status"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Width = 140
        '
        'btnVisualizar
        '
        Me.btnVisualizar.HeaderText = "Visualizar"
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.ToolTipText = "Visualizar"
        Me.btnVisualizar.UseColumnTextForButtonValue = True
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.HeaderText = "Enviar Email"
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.UseColumnTextForButtonValue = True
        '
        'FrmNotasEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 511)
        Me.Controls.Add(Me.tbItensEcontrados)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtperiodo)
        Me.Controls.Add(Me.txtate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmNotasEmitidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNotasEmitidas"
        Me.tbItensEcontrados.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgProdutosVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTAFISCALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbItensEcontrados As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgProdutosVendidos As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSair As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPesqusiar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtperiodo As MaskedTextBox
    Friend WithEvents txtate As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NOTAFISCALBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents INSERIRNOTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NUMNOTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODCFOPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODFORMAPAGTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLABORADOR As DataGridViewTextBoxColumn
    Friend WithEvents TOTALNFEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents btnVisualizar As DataGridViewButtonColumn
    Friend WithEvents btnEnviarEmail As DataGridViewButtonColumn
End Class
