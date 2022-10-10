<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItensMovimento
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MOVIMENTOITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.CODORCAMENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODABERTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOVENDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMENTOITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 89)
        Me.Panel1.TabIndex = 0
        '
        'dgConsultaCliente
        '
        Me.dgConsultaCliente.AllowUserToAddRows = False
        Me.dgConsultaCliente.AllowUserToDeleteRows = False
        Me.dgConsultaCliente.AutoGenerateColumns = False
        Me.dgConsultaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgConsultaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgConsultaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConsultaCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsultaCliente.ColumnHeadersHeight = 20
        Me.dgConsultaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODORCAMENTODataGridViewTextBoxColumn, Me.CODCAIXA, Me.CODABERTURADataGridViewTextBoxColumn, Me.QUANTIDADEDataGridViewTextBoxColumn, Me.PRECOVENDADataGridViewTextBoxColumn, Me.TOTALITEMDataGridViewTextBoxColumn})
        Me.dgConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgConsultaCliente.DataSource = Me.MOVIMENTOITEMBindingSource
        Me.dgConsultaCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgConsultaCliente.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgConsultaCliente.Location = New System.Drawing.Point(0, 114)
        Me.dgConsultaCliente.Name = "dgConsultaCliente"
        Me.dgConsultaCliente.ReadOnly = True
        Me.dgConsultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaCliente.Size = New System.Drawing.Size(728, 230)
        Me.dgConsultaCliente.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Itens do Movimento"
        '
        'MOVIMENTOITEMBindingSource
        '
        Me.MOVIMENTOITEMBindingSource.DataMember = "MOVIMENTO_ITEM"
        Me.MOVIMENTOITEMBindingSource.DataSource = Me.DsAmbiente
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CODORCAMENTODataGridViewTextBoxColumn
        '
        Me.CODORCAMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODORCAMENTODataGridViewTextBoxColumn.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn.HeaderText = "Codigo Orçamento"
        Me.CODORCAMENTODataGridViewTextBoxColumn.Name = "CODORCAMENTODataGridViewTextBoxColumn"
        Me.CODORCAMENTODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODORCAMENTODataGridViewTextBoxColumn.Width = 115
        '
        'CODCAIXA
        '
        Me.CODCAIXA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCAIXA.DataPropertyName = "CODCAIXA"
        Me.CODCAIXA.FillWeight = 378.0488!
        Me.CODCAIXA.HeaderText = "Codigo Caixa"
        Me.CODCAIXA.Name = "CODCAIXA"
        Me.CODCAIXA.ReadOnly = True
        Me.CODCAIXA.Width = 90
        '
        'CODABERTURADataGridViewTextBoxColumn
        '
        Me.CODABERTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODABERTURADataGridViewTextBoxColumn.DataPropertyName = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn.FillWeight = 30.48781!
        Me.CODABERTURADataGridViewTextBoxColumn.HeaderText = "Codigo Abertura"
        Me.CODABERTURADataGridViewTextBoxColumn.Name = "CODABERTURADataGridViewTextBoxColumn"
        Me.CODABERTURADataGridViewTextBoxColumn.ReadOnly = True
        Me.CODABERTURADataGridViewTextBoxColumn.Width = 120
        '
        'QUANTIDADEDataGridViewTextBoxColumn
        '
        Me.QUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE"
        Me.QUANTIDADEDataGridViewTextBoxColumn.FillWeight = 30.48781!
        Me.QUANTIDADEDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QUANTIDADEDataGridViewTextBoxColumn.Name = "QUANTIDADEDataGridViewTextBoxColumn"
        Me.QUANTIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECOVENDADataGridViewTextBoxColumn
        '
        Me.PRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECO_VENDA"
        Me.PRECOVENDADataGridViewTextBoxColumn.FillWeight = 30.48781!
        Me.PRECOVENDADataGridViewTextBoxColumn.HeaderText = "Preco Venda"
        Me.PRECOVENDADataGridViewTextBoxColumn.Name = "PRECOVENDADataGridViewTextBoxColumn"
        Me.PRECOVENDADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALITEMDataGridViewTextBoxColumn
        '
        Me.TOTALITEMDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_ITEM"
        Me.TOTALITEMDataGridViewTextBoxColumn.FillWeight = 30.48781!
        Me.TOTALITEMDataGridViewTextBoxColumn.HeaderText = "Total Item"
        Me.TOTALITEMDataGridViewTextBoxColumn.Name = "TOTALITEMDataGridViewTextBoxColumn"
        Me.TOTALITEMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmItensMovimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 344)
        Me.Controls.Add(Me.dgConsultaCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmItensMovimento"
        Me.Text = "Itens Movimento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMENTOITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgConsultaCliente As DataGridView
    Friend WithEvents MOVIMENTOITEMBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents CODORCAMENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXA As DataGridViewTextBoxColumn
    Friend WithEvents CODABERTURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECOVENDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
