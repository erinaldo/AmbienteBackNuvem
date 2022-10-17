<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoricoMovementacaoItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistoricoMovementacaoItens))
        Me.tbItens = New System.Windows.Forms.TabControl()
        Me.tpItenEncontrado = New System.Windows.Forms.TabPage()
        Me.dg_RelHistoricoCliente = New System.Windows.Forms.DataGridView()
        Me.lblNmrVale = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.DEBITOITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODORCAMENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODABERTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOVENDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALITEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOBARRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbItens.SuspendLayout()
        Me.tpItenEncontrado.SuspendLayout()
        CType(Me.dg_RelHistoricoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBITOITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbItens
        '
        Me.tbItens.Controls.Add(Me.tpItenEncontrado)
        Me.tbItens.Location = New System.Drawing.Point(0, 101)
        Me.tbItens.Name = "tbItens"
        Me.tbItens.SelectedIndex = 0
        Me.tbItens.Size = New System.Drawing.Size(776, 351)
        Me.tbItens.TabIndex = 35
        '
        'tpItenEncontrado
        '
        Me.tpItenEncontrado.Controls.Add(Me.dg_RelHistoricoCliente)
        Me.tpItenEncontrado.Location = New System.Drawing.Point(4, 22)
        Me.tpItenEncontrado.Name = "tpItenEncontrado"
        Me.tpItenEncontrado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItenEncontrado.Size = New System.Drawing.Size(768, 325)
        Me.tpItenEncontrado.TabIndex = 0
        Me.tpItenEncontrado.Text = "Itens Encontrados"
        Me.tpItenEncontrado.UseVisualStyleBackColor = True
        '
        'dg_RelHistoricoCliente
        '
        Me.dg_RelHistoricoCliente.AllowUserToAddRows = False
        Me.dg_RelHistoricoCliente.AllowUserToDeleteRows = False
        Me.dg_RelHistoricoCliente.AllowUserToOrderColumns = True
        Me.dg_RelHistoricoCliente.AllowUserToResizeColumns = False
        Me.dg_RelHistoricoCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dg_RelHistoricoCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_RelHistoricoCliente.AutoGenerateColumns = False
        Me.dg_RelHistoricoCliente.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_RelHistoricoCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_RelHistoricoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_RelHistoricoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODORCAMENTODataGridViewTextBoxColumn, Me.CODABERTURADataGridViewTextBoxColumn, Me.CODCAIXADataGridViewTextBoxColumn, Me.QUANTIDADEDataGridViewTextBoxColumn, Me.PRECOVENDADataGridViewTextBoxColumn, Me.TOTALITEMDataGridViewTextBoxColumn, Me.CODIGOBARRADataGridViewTextBoxColumn})
        Me.dg_RelHistoricoCliente.DataSource = Me.DEBITOITEMBindingSource
        Me.dg_RelHistoricoCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_RelHistoricoCliente.GridColor = System.Drawing.Color.White
        Me.dg_RelHistoricoCliente.Location = New System.Drawing.Point(3, 3)
        Me.dg_RelHistoricoCliente.Name = "dg_RelHistoricoCliente"
        Me.dg_RelHistoricoCliente.Size = New System.Drawing.Size(762, 319)
        Me.dg_RelHistoricoCliente.TabIndex = 0
        '
        'lblNmrVale
        '
        Me.lblNmrVale.AutoSize = True
        Me.lblNmrVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmrVale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNmrVale.Location = New System.Drawing.Point(469, 11)
        Me.lblNmrVale.Name = "lblNmrVale"
        Me.lblNmrVale.Size = New System.Drawing.Size(44, 39)
        Me.lblNmrVale.TabIndex = 4
        Me.lblNmrVale.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(66, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Itens Vendidos do Vale ="
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.lblNmrVale)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 95)
        Me.Panel2.TabIndex = 34
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(687, 43)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(77, 40)
        Me.btnSair.TabIndex = 28
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEBITOITEMBindingSource
        '
        Me.DEBITOITEMBindingSource.DataMember = "DEBITO_ITEM"
        Me.DEBITOITEMBindingSource.DataSource = Me.DsAmbiente
        '
        'CODORCAMENTODataGridViewTextBoxColumn
        '
        Me.CODORCAMENTODataGridViewTextBoxColumn.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn.HeaderText = "CODORCAMENTO"
        Me.CODORCAMENTODataGridViewTextBoxColumn.Name = "CODORCAMENTODataGridViewTextBoxColumn"
        '
        'CODABERTURADataGridViewTextBoxColumn
        '
        Me.CODABERTURADataGridViewTextBoxColumn.DataPropertyName = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn.HeaderText = "CODABERTURA"
        Me.CODABERTURADataGridViewTextBoxColumn.Name = "CODABERTURADataGridViewTextBoxColumn"
        '
        'CODCAIXADataGridViewTextBoxColumn
        '
        Me.CODCAIXADataGridViewTextBoxColumn.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn.HeaderText = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn.Name = "CODCAIXADataGridViewTextBoxColumn"
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
        'FrmHistoricoMovementacaoItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 453)
        Me.Controls.Add(Me.tbItens)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHistoricoMovementacaoItens"
        Me.Text = "FrmHistoricoMovementacaoItens"
        Me.tbItens.ResumeLayout(False)
        Me.tpItenEncontrado.ResumeLayout(False)
        CType(Me.dg_RelHistoricoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBITOITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbItens As TabControl
    Friend WithEvents tpItenEncontrado As TabPage
    Friend WithEvents dg_RelHistoricoCliente As DataGridView
    Friend WithEvents lblNmrVale As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSair As Button
    Friend WithEvents CODORCAMENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODABERTURADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECOVENDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALITEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOBARRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEBITOITEMBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
End Class
