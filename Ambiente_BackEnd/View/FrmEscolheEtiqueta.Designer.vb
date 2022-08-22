<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscolheEtiqueta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGerarEtiqueta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.PRODUTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.CODPRODUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODBARRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRICAODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO_VENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etiqueta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGerarEtiqueta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 43)
        Me.Panel1.TabIndex = 0
        '
        'btnGerarEtiqueta
        '
        Me.btnGerarEtiqueta.Location = New System.Drawing.Point(12, 6)
        Me.btnGerarEtiqueta.Name = "btnGerarEtiqueta"
        Me.btnGerarEtiqueta.Size = New System.Drawing.Size(132, 25)
        Me.btnGerarEtiqueta.TabIndex = 0
        Me.btnGerarEtiqueta.Text = "Gerar Etiqueta"
        Me.btnGerarEtiqueta.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 66)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(241, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etiqueta de Produtos"
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUTOBindingSource
        '
        Me.PRODUTOBindingSource.DataMember = "PRODUTO"
        Me.PRODUTOBindingSource.DataSource = Me.DsAmbiente
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgProdutos.ColumnHeadersHeight = 20
        Me.dgProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPRODUTODataGridViewTextBoxColumn, Me.CODBARRADataGridViewTextBoxColumn, Me.DESCRICAODataGridViewTextBoxColumn, Me.PRECO_VENDA, Me.etiqueta})
        Me.dgProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgProdutos.DataSource = Me.PRODUTOBindingSource
        Me.dgProdutos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgProdutos.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgProdutos.Location = New System.Drawing.Point(0, 114)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProdutos.Size = New System.Drawing.Size(899, 335)
        Me.dgProdutos.TabIndex = 49
        '
        'CODPRODUTODataGridViewTextBoxColumn
        '
        Me.CODPRODUTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CODPRODUTO"
        Me.CODPRODUTODataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CODPRODUTODataGridViewTextBoxColumn.Name = "CODPRODUTODataGridViewTextBoxColumn"
        Me.CODPRODUTODataGridViewTextBoxColumn.Width = 70
        '
        'CODBARRADataGridViewTextBoxColumn
        '
        Me.CODBARRADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODBARRADataGridViewTextBoxColumn.DataPropertyName = "CODBARRA"
        Me.CODBARRADataGridViewTextBoxColumn.HeaderText = "Codigo Barra"
        Me.CODBARRADataGridViewTextBoxColumn.Name = "CODBARRADataGridViewTextBoxColumn"
        Me.CODBARRADataGridViewTextBoxColumn.Width = 160
        '
        'DESCRICAODataGridViewTextBoxColumn
        '
        Me.DESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO"
        Me.DESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DESCRICAODataGridViewTextBoxColumn.Name = "DESCRICAODataGridViewTextBoxColumn"
        Me.DESCRICAODataGridViewTextBoxColumn.Width = 400
        '
        'PRECO_VENDA
        '
        Me.PRECO_VENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRECO_VENDA.DataPropertyName = "PRECO_VENDA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PRECO_VENDA.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRECO_VENDA.HeaderText = "Preço Venda"
        Me.PRECO_VENDA.Name = "PRECO_VENDA"
        Me.PRECO_VENDA.Width = 125
        '
        'etiqueta
        '
        Me.etiqueta.HeaderText = "Etiqueta"
        Me.etiqueta.Name = "etiqueta"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Pesquisar"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(4, 88)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(269, 20)
        Me.txtPesquisar.TabIndex = 54
        '
        'FrmEscolheEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 492)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.dgProdutos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEscolheEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolher Etiqueta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents PRODUTOBindingSource As BindingSource
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents btnGerarEtiqueta As Button
    Friend WithEvents CODPRODUTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODBARRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRICAODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECO_VENDA As DataGridViewTextBoxColumn
    Friend WithEvents etiqueta As DataGridViewCheckBoxColumn
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
End Class
