﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAtualizaPreco
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtualizaPreco = New System.Windows.Forms.Button()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.IdProdutosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigobarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecovendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selecionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdutosNuvemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente1 = New Ambiente_BackEnd.dsAmbiente()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosNuvemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 58
        Me.Label26.Text = "Pesquisar"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(4, 88)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(269, 20)
        Me.txtPesquisar.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 66)
        Me.Panel2.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(334, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Atualiza Preços"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAtualizaPreco)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 43)
        Me.Panel1.TabIndex = 55
        '
        'btnAtualizaPreco
        '
        Me.btnAtualizaPreco.Location = New System.Drawing.Point(12, 6)
        Me.btnAtualizaPreco.Name = "btnAtualizaPreco"
        Me.btnAtualizaPreco.Size = New System.Drawing.Size(132, 25)
        Me.btnAtualizaPreco.TabIndex = 0
        Me.btnAtualizaPreco.Text = "Atualizar Preços"
        Me.btnAtualizaPreco.UseVisualStyleBackColor = True
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgProdutos.ColumnHeadersHeight = 20
        Me.dgProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProdutosDataGridViewTextBoxColumn, Me.CodigobarraDataGridViewTextBoxColumn, Me.ProdutoDataGridViewTextBoxColumn, Me.PrecovendaDataGridViewTextBoxColumn, Me.selecionado})
        Me.dgProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgProdutos.DataSource = Me.ProdutosNuvemBindingSource
        Me.dgProdutos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgProdutos.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgProdutos.Location = New System.Drawing.Point(0, 114)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProdutos.Size = New System.Drawing.Size(899, 335)
        Me.dgProdutos.TabIndex = 60
        '
        'IdProdutosDataGridViewTextBoxColumn
        '
        Me.IdProdutosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IdProdutosDataGridViewTextBoxColumn.DataPropertyName = "idProdutos"
        Me.IdProdutosDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.IdProdutosDataGridViewTextBoxColumn.Name = "IdProdutosDataGridViewTextBoxColumn"
        Me.IdProdutosDataGridViewTextBoxColumn.Width = 70
        '
        'CodigobarraDataGridViewTextBoxColumn
        '
        Me.CodigobarraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CodigobarraDataGridViewTextBoxColumn.DataPropertyName = "codigobarra"
        Me.CodigobarraDataGridViewTextBoxColumn.HeaderText = "Codigo Barra"
        Me.CodigobarraDataGridViewTextBoxColumn.Name = "CodigobarraDataGridViewTextBoxColumn"
        Me.CodigobarraDataGridViewTextBoxColumn.Width = 135
        '
        'ProdutoDataGridViewTextBoxColumn
        '
        Me.ProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdutoDataGridViewTextBoxColumn.DataPropertyName = "produto"
        Me.ProdutoDataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.ProdutoDataGridViewTextBoxColumn.Name = "ProdutoDataGridViewTextBoxColumn"
        '
        'PrecovendaDataGridViewTextBoxColumn
        '
        Me.PrecovendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PrecovendaDataGridViewTextBoxColumn.DataPropertyName = "precovenda"
        Me.PrecovendaDataGridViewTextBoxColumn.HeaderText = "Preco Venda"
        Me.PrecovendaDataGridViewTextBoxColumn.Name = "PrecovendaDataGridViewTextBoxColumn"
        Me.PrecovendaDataGridViewTextBoxColumn.Width = 115
        '
        'selecionado
        '
        Me.selecionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.selecionado.HeaderText = "Selecionado"
        Me.selecionado.Name = "selecionado"
        Me.selecionado.Width = 80
        '
        'ProdutosNuvemBindingSource
        '
        Me.ProdutosNuvemBindingSource.DataMember = "ProdutosNuvem"
        Me.ProdutosNuvemBindingSource.DataSource = Me.DsAmbiente1
        '
        'DsAmbiente1
        '
        Me.DsAmbiente1.DataSetName = "dsAmbiente"
        Me.DsAmbiente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmAtualizaPreco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 492)
        Me.Controls.Add(Me.dgProdutos)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAtualizaPreco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualiza Preço"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosNuvemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAtualizaPreco As Button
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents IdProdutosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigobarraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecovendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents selecionado As DataGridViewCheckBoxColumn
    Friend WithEvents ProdutosNuvemBindingSource As BindingSource
    Friend WithEvents DsAmbiente1 As dsAmbiente
End Class
