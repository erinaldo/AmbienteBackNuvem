<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroCategoria))
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.dg_funcionario = New System.Windows.Forms.DataGridView()
        Me.CODCATEGORIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRICAODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.tbCategoria = New System.Windows.Forms.TabControl()
        Me.cbxAtivo = New System.Windows.Forms.ComboBox()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btninserir = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPesquisa.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tpCadastrar.SuspendLayout()
        Me.tbCategoria.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 11)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Filtro :"
        '
        'cbxFiltro
        '
        Me.cbxFiltro.FormattingEnabled = True
        Me.cbxFiltro.Items.AddRange(New Object() {"CODIGO", "NOME", "CPF"})
        Me.cbxFiltro.Location = New System.Drawing.Point(6, 29)
        Me.cbxFiltro.Name = "cbxFiltro"
        Me.cbxFiltro.Size = New System.Drawing.Size(113, 21)
        Me.cbxFiltro.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(122, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Pesquisar"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(125, 29)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(503, 20)
        Me.txtPesquisar.TabIndex = 52
        '
        'dg_funcionario
        '
        Me.dg_funcionario.AllowUserToAddRows = False
        Me.dg_funcionario.AllowUserToDeleteRows = False
        Me.dg_funcionario.AutoGenerateColumns = False
        Me.dg_funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_funcionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_funcionario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_funcionario.ColumnHeadersHeight = 20
        Me.dg_funcionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODCATEGORIADataGridViewTextBoxColumn, Me.DESCRICAODataGridViewTextBoxColumn, Me.ATIVODataGridViewTextBoxColumn})
        Me.dg_funcionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_funcionario.DataSource = Me.CATEGORIABindingSource
        Me.dg_funcionario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg_funcionario.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dg_funcionario.Location = New System.Drawing.Point(3, 56)
        Me.dg_funcionario.Name = "dg_funcionario"
        Me.dg_funcionario.ReadOnly = True
        Me.dg_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_funcionario.Size = New System.Drawing.Size(770, 179)
        Me.dg_funcionario.TabIndex = 48
        '
        'CODCATEGORIADataGridViewTextBoxColumn
        '
        Me.CODCATEGORIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCATEGORIADataGridViewTextBoxColumn.DataPropertyName = "CODCATEGORIA"
        Me.CODCATEGORIADataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CODCATEGORIADataGridViewTextBoxColumn.Name = "CODCATEGORIADataGridViewTextBoxColumn"
        Me.CODCATEGORIADataGridViewTextBoxColumn.ReadOnly = True
        Me.CODCATEGORIADataGridViewTextBoxColumn.Width = 70
        '
        'DESCRICAODataGridViewTextBoxColumn
        '
        Me.DESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO"
        Me.DESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DESCRICAODataGridViewTextBoxColumn.Name = "DESCRICAODataGridViewTextBoxColumn"
        Me.DESCRICAODataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRICAODataGridViewTextBoxColumn.Width = 570
        '
        'ATIVODataGridViewTextBoxColumn
        '
        Me.ATIVODataGridViewTextBoxColumn.DataPropertyName = "ATIVO"
        Me.ATIVODataGridViewTextBoxColumn.HeaderText = "Ativo"
        Me.ATIVODataGridViewTextBoxColumn.Name = "ATIVODataGridViewTextBoxColumn"
        Me.ATIVODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CATEGORIABindingSource
        '
        Me.CATEGORIABindingSource.DataMember = "CATEGORIA"
        Me.CATEGORIABindingSource.DataSource = Me.DsAmbiente
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label27)
        Me.tpPesquisa.Controls.Add(Me.cbxFiltro)
        Me.tpPesquisa.Controls.Add(Me.Label26)
        Me.tpPesquisa.Controls.Add(Me.txtPesquisar)
        Me.tpPesquisa.Controls.Add(Me.dg_funcionario)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPesquisa.Size = New System.Drawing.Size(776, 238)
        Me.tpPesquisa.TabIndex = 1
        Me.tpPesquisa.Text = "Pesquisar Categoria"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(140, 54)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(242, 21)
        Me.txtDescricao.TabIndex = 1
        '
        'txtCodCategoria
        '
        Me.txtCodCategoria.Enabled = False
        Me.txtCodCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCategoria.Location = New System.Drawing.Point(140, 21)
        Me.txtCodCategoria.Name = "txtCodCategoria"
        Me.txtCodCategoria.Size = New System.Drawing.Size(67, 21)
        Me.txtCodCategoria.TabIndex = 2246
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2248
        Me.Label2.Text = "Descrição :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(70, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 2247
        Me.Label4.Text = "Código :"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtDescricao)
        Me.Panel7.Controls.Add(Me.txtCodCategoria)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(770, 232)
        Me.Panel7.TabIndex = 159
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.Panel7)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(776, 238)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar Categoria"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'tbCategoria
        '
        Me.tbCategoria.Controls.Add(Me.tpCadastrar)
        Me.tbCategoria.Controls.Add(Me.tpPesquisa)
        Me.tbCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCategoria.Location = New System.Drawing.Point(0, 67)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.SelectedIndex = 0
        Me.tbCategoria.Size = New System.Drawing.Size(784, 264)
        Me.tbCategoria.TabIndex = 215
        '
        'cbxAtivo
        '
        Me.cbxAtivo.FormattingEnabled = True
        Me.cbxAtivo.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.cbxAtivo.Location = New System.Drawing.Point(80, 7)
        Me.cbxAtivo.Name = "cbxAtivo"
        Me.cbxAtivo.Size = New System.Drawing.Size(114, 21)
        Me.cbxAtivo.TabIndex = 21
        Me.cbxAtivo.Text = "SIM"
        '
        'btnpesquisar
        '
        Me.btnpesquisar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnpesquisar.FlatAppearance.BorderSize = 0
        Me.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnpesquisar.Image = CType(resources.GetObject("btnpesquisar.Image"), System.Drawing.Image)
        Me.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpesquisar.Location = New System.Drawing.Point(509, 0)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(123, 67)
        Me.btnpesquisar.TabIndex = 158
        Me.btnpesquisar.Text = "F5 - Pesquisar"
        Me.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(372, 0)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(115, 67)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "F4 - Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsalvar.FlatAppearance.BorderSize = 0
        Me.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalvar.ForeColor = System.Drawing.Color.Black
        Me.btnsalvar.Image = CType(resources.GetObject("btnsalvar.Image"), System.Drawing.Image)
        Me.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalvar.Location = New System.Drawing.Point(251, 0)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(99, 67)
        Me.btnsalvar.TabIndex = 37
        Me.btnsalvar.Text = "F3 - Salvar"
        Me.btnsalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.Black
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneditar.Location = New System.Drawing.Point(124, 0)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(105, 67)
        Me.btneditar.TabIndex = 35
        Me.btneditar.Text = "F2 - Editar"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btninserir
        '
        Me.btninserir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btninserir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btninserir.FlatAppearance.BorderSize = 0
        Me.btninserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninserir.ForeColor = System.Drawing.Color.Black
        Me.btninserir.Image = CType(resources.GetObject("btninserir.Image"), System.Drawing.Image)
        Me.btninserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btninserir.Location = New System.Drawing.Point(0, 0)
        Me.btninserir.Name = "btninserir"
        Me.btninserir.Size = New System.Drawing.Size(102, 67)
        Me.btninserir.TabIndex = 32
        Me.btninserir.Text = "F1 - Inserir"
        Me.btninserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninserir.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.cbxAtivo)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 331)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(784, 40)
        Me.Panel8.TabIndex = 214
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(27, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = "Ativo :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFechar)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btnpesquisar)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnsalvar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btneditar)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btninserir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 67)
        Me.Panel2.TabIndex = 213
        '
        'btnFechar
        '
        Me.btnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFechar.Location = New System.Drawing.Point(666, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(118, 67)
        Me.btnFechar.TabIndex = 162
        Me.btnFechar.Text = "F12 - Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(632, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(22, 67)
        Me.Panel6.TabIndex = 159
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(487, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 67)
        Me.Panel5.TabIndex = 40
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(350, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(22, 67)
        Me.Panel4.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(229, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 67)
        Me.Panel3.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(102, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 67)
        Me.Panel1.TabIndex = 34
        '
        'FrmCadastroCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 371)
        Me.Controls.Add(Me.tbCategoria)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroCategoria"
        Me.Text = "FrmCadastroCategoria"
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.tpCadastrar.ResumeLayout(False)
        Me.tbCategoria.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label27 As Label
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents dg_funcionario As DataGridView
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtCodCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents tbCategoria As TabControl
    Friend WithEvents cbxAtivo As ComboBox
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btninserir As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CODCATEGORIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRICAODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ATIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORIABindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents btnFechar As Button
End Class
