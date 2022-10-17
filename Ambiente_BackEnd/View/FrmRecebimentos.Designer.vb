<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecebimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecebimentos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblcodigocliente = New System.Windows.Forms.Label()
        Me.lblnomecliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dg_recebimento = New System.Windows.Forms.DataGridView()
        Me.DEBITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.tpItenEncontrado = New System.Windows.Forms.TabPage()
        Me.btnQuitarRecebimento = New System.Windows.Forms.Button()
        Me.tbItens = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CODORCAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCAIXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVerItens = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_recebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpItenEncontrado.SuspendLayout()
        Me.tbItens.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.lblcodigocliente)
        Me.Panel2.Controls.Add(Me.lblnomecliente)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 95)
        Me.Panel2.TabIndex = 35
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(496, 45)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(77, 40)
        Me.btnSair.TabIndex = 27
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblcodigocliente
        '
        Me.lblcodigocliente.AutoSize = True
        Me.lblcodigocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigocliente.Location = New System.Drawing.Point(12, 68)
        Me.lblcodigocliente.Name = "lblcodigocliente"
        Me.lblcodigocliente.Size = New System.Drawing.Size(16, 17)
        Me.lblcodigocliente.TabIndex = 5
        Me.lblcodigocliente.Text = ".."
        '
        'lblnomecliente
        '
        Me.lblnomecliente.AutoSize = True
        Me.lblnomecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomecliente.Location = New System.Drawing.Point(77, 68)
        Me.lblnomecliente.Name = "lblnomecliente"
        Me.lblnomecliente.Size = New System.Drawing.Size(16, 17)
        Me.lblnomecliente.TabIndex = 4
        Me.lblnomecliente.Text = ".."
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
        Me.Label2.Size = New System.Drawing.Size(235, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recebimentos"
        '
        'nTotal
        '
        Me.nTotal.DecimalPlaces = 2
        Me.nTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nTotal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nTotal.Location = New System.Drawing.Point(304, 507)
        Me.nTotal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nTotal.Name = "nTotal"
        Me.nTotal.Size = New System.Drawing.Size(10, 21)
        Me.nTotal.TabIndex = 506
        Me.nTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nTotal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(320, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Total :"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(390, 498)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 35)
        Me.txtTotal.TabIndex = 24
        '
        'dg_recebimento
        '
        Me.dg_recebimento.AllowUserToAddRows = False
        Me.dg_recebimento.AllowUserToDeleteRows = False
        Me.dg_recebimento.AllowUserToOrderColumns = True
        Me.dg_recebimento.AllowUserToResizeColumns = False
        Me.dg_recebimento.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dg_recebimento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_recebimento.AutoGenerateColumns = False
        Me.dg_recebimento.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_recebimento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_recebimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_recebimento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODORCAMENTO, Me.CODCAIXADataGridViewTextBoxColumn, Me.DATA, Me.TIPO, Me.TOTALDataGridViewTextBoxColumn, Me.btnVerItens})
        Me.dg_recebimento.DataSource = Me.DEBITOBindingSource
        Me.dg_recebimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_recebimento.GridColor = System.Drawing.Color.White
        Me.dg_recebimento.Location = New System.Drawing.Point(3, 3)
        Me.dg_recebimento.Name = "dg_recebimento"
        Me.dg_recebimento.Size = New System.Drawing.Size(560, 410)
        Me.dg_recebimento.TabIndex = 0
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
        'tpItenEncontrado
        '
        Me.tpItenEncontrado.Controls.Add(Me.dg_recebimento)
        Me.tpItenEncontrado.Location = New System.Drawing.Point(4, 22)
        Me.tpItenEncontrado.Name = "tpItenEncontrado"
        Me.tpItenEncontrado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItenEncontrado.Size = New System.Drawing.Size(566, 416)
        Me.tpItenEncontrado.TabIndex = 0
        Me.tpItenEncontrado.Text = "Itens Encontrados"
        Me.tpItenEncontrado.UseVisualStyleBackColor = True
        '
        'btnQuitarRecebimento
        '
        Me.btnQuitarRecebimento.Location = New System.Drawing.Point(410, 18)
        Me.btnQuitarRecebimento.Name = "btnQuitarRecebimento"
        Me.btnQuitarRecebimento.Size = New System.Drawing.Size(163, 30)
        Me.btnQuitarRecebimento.TabIndex = 26
        Me.btnQuitarRecebimento.Text = "F5 - Quitar Recebimento"
        Me.btnQuitarRecebimento.UseVisualStyleBackColor = True
        '
        'tbItens
        '
        Me.tbItens.Controls.Add(Me.tpItenEncontrado)
        Me.tbItens.Location = New System.Drawing.Point(3, 54)
        Me.tbItens.Name = "tbItens"
        Me.tbItens.SelectedIndex = 0
        Me.tbItens.Size = New System.Drawing.Size(574, 442)
        Me.tbItens.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.nTotal)
        Me.Panel1.Controls.Add(Me.btnQuitarRecebimento)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.tbItens)
        Me.Panel1.Location = New System.Drawing.Point(0, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 538)
        Me.Panel1.TabIndex = 36
        '
        'CODORCAMENTO
        '
        Me.CODORCAMENTO.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTO.HeaderText = "Codigo Orcamento"
        Me.CODORCAMENTO.Name = "CODORCAMENTO"
        Me.CODORCAMENTO.Visible = False
        '
        'CODCAIXADataGridViewTextBoxColumn
        '
        Me.CODCAIXADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCAIXADataGridViewTextBoxColumn.DataPropertyName = "CODCAIXA"
        Me.CODCAIXADataGridViewTextBoxColumn.HeaderText = "Caixa"
        Me.CODCAIXADataGridViewTextBoxColumn.Name = "CODCAIXADataGridViewTextBoxColumn"
        Me.CODCAIXADataGridViewTextBoxColumn.Width = 65
        '
        'DATA
        '
        Me.DATA.DataPropertyName = "DATA"
        Me.DATA.HeaderText = "Data"
        Me.DATA.Name = "DATA"
        Me.DATA.Width = 85
        '
        'TIPO
        '
        Me.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TOTALDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'btnVerItens
        '
        Me.btnVerItens.HeaderText = "Visualizar"
        Me.btnVerItens.Name = "btnVerItens"
        Me.btnVerItens.Width = 140
        '
        'FrmRecebimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmRecebimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_recebimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpItenEncontrado.ResumeLayout(False)
        Me.tbItens.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSair As Button
    Friend WithEvents lblcodigocliente As Label
    Friend WithEvents lblnomecliente As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Public WithEvents nTotal As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dg_recebimento As DataGridView
    Friend WithEvents DEBITOBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents tpItenEncontrado As TabPage
    Friend WithEvents btnQuitarRecebimento As Button
    Friend WithEvents tbItens As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CODORCAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CODCAIXADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnVerItens As DataGridViewButtonColumn
End Class
