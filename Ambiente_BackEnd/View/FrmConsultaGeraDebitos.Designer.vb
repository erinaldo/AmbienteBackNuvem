<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGeraDebitos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaGeraDebitos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbItens = New System.Windows.Forms.TabControl()
        Me.tpItenEncontrado = New System.Windows.Forms.TabPage()
        Me.dg_recebimento = New System.Windows.Forms.DataGridView()
        Me.DEBITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.nTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CODORCAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAOSOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.tbItens.SuspendLayout()
        Me.tpItenEncontrado.SuspendLayout()
        CType(Me.dg_recebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbItens)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 546)
        Me.Panel1.TabIndex = 38
        '
        'tbItens
        '
        Me.tbItens.Controls.Add(Me.tpItenEncontrado)
        Me.tbItens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbItens.Location = New System.Drawing.Point(0, 0)
        Me.tbItens.Name = "tbItens"
        Me.tbItens.SelectedIndex = 0
        Me.tbItens.Size = New System.Drawing.Size(796, 498)
        Me.tbItens.TabIndex = 508
        '
        'tpItenEncontrado
        '
        Me.tpItenEncontrado.Controls.Add(Me.dg_recebimento)
        Me.tpItenEncontrado.Location = New System.Drawing.Point(4, 22)
        Me.tpItenEncontrado.Name = "tpItenEncontrado"
        Me.tpItenEncontrado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItenEncontrado.Size = New System.Drawing.Size(788, 472)
        Me.tpItenEncontrado.TabIndex = 0
        Me.tpItenEncontrado.Text = "Itens Encontrados"
        Me.tpItenEncontrado.UseVisualStyleBackColor = True
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
        Me.dg_recebimento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODORCAMENTO, Me.CODCLIENTE, Me.RAZAOSOCIAL, Me.TOTALDataGridViewTextBoxColumn})
        Me.dg_recebimento.DataSource = Me.DEBITOBindingSource
        Me.dg_recebimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_recebimento.GridColor = System.Drawing.Color.White
        Me.dg_recebimento.Location = New System.Drawing.Point(3, 3)
        Me.dg_recebimento.Name = "dg_recebimento"
        Me.dg_recebimento.Size = New System.Drawing.Size(782, 466)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.nTotal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 498)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(796, 48)
        Me.Panel3.TabIndex = 507
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(604, 10)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 35)
        Me.txtTotal.TabIndex = 24
        '
        'nTotal
        '
        Me.nTotal.DecimalPlaces = 2
        Me.nTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nTotal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nTotal.Location = New System.Drawing.Point(518, 19)
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
        Me.Label3.Location = New System.Drawing.Point(534, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Total :"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(715, 49)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(77, 40)
        Me.btnSair.TabIndex = 27
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 21)
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
        Me.Label2.Location = New System.Drawing.Point(66, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Consulta Debitos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSair)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 95)
        Me.Panel2.TabIndex = 37
        '
        'CODORCAMENTO
        '
        Me.CODORCAMENTO.DataPropertyName = "CODORCAMENTO"
        Me.CODORCAMENTO.HeaderText = "Codigo Orcamento"
        Me.CODORCAMENTO.Name = "CODORCAMENTO"
        Me.CODORCAMENTO.Visible = False
        '
        'CODCLIENTE
        '
        Me.CODCLIENTE.DataPropertyName = "CODCLIENTE"
        Me.CODCLIENTE.HeaderText = "Cod Cliente"
        Me.CODCLIENTE.Name = "CODCLIENTE"
        '
        'RAZAOSOCIAL
        '
        Me.RAZAOSOCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RAZAOSOCIAL.DataPropertyName = "RAZAOSOCIAL"
        Me.RAZAOSOCIAL.HeaderText = "Nome Cliente"
        Me.RAZAOSOCIAL.Name = "RAZAOSOCIAL"
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
        'FrmConsultaGeraDebitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmConsultaGeraDebitos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Debitos"
        Me.Panel1.ResumeLayout(False)
        Me.tbItens.ResumeLayout(False)
        Me.tpItenEncontrado.ResumeLayout(False)
        CType(Me.dg_recebimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents DEBITOBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Public WithEvents nTotal As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbItens As TabControl
    Friend WithEvents tpItenEncontrado As TabPage
    Friend WithEvents dg_recebimento As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CODORCAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CODCLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents RAZAOSOCIAL As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
