<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroCusto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroCusto))
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.dg_funcionario = New System.Windows.Forms.DataGridView()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.nPercentual = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodCusto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCusto = New System.Windows.Forms.TabControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btninserir = New System.Windows.Forms.Button()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.GERACUSTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODGERACUSTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRICAODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERCENTUALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPesquisa.SuspendLayout()
        Me.tpCadastrar.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.nPercentual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCusto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GERACUSTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cbxFiltro.Items.AddRange(New Object() {"DESCRICAO"})
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_funcionario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_funcionario.ColumnHeadersHeight = 20
        Me.dg_funcionario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODGERACUSTODataGridViewTextBoxColumn, Me.DESCRICAODataGridViewTextBoxColumn, Me.PERCENTUALDataGridViewTextBoxColumn})
        Me.dg_funcionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_funcionario.DataSource = Me.GERACUSTOBindingSource
        Me.dg_funcionario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg_funcionario.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dg_funcionario.Location = New System.Drawing.Point(3, 56)
        Me.dg_funcionario.Name = "dg_funcionario"
        Me.dg_funcionario.ReadOnly = True
        Me.dg_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_funcionario.Size = New System.Drawing.Size(764, 182)
        Me.dg_funcionario.TabIndex = 48
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
        Me.tpPesquisa.Size = New System.Drawing.Size(770, 241)
        Me.tpPesquisa.TabIndex = 1
        Me.tpPesquisa.Text = "Pesquisar Produto"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.Panel7)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(770, 241)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar Custo"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.nPercentual)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.txtDescricao)
        Me.Panel7.Controls.Add(Me.txtCodCusto)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(764, 235)
        Me.Panel7.TabIndex = 159
        '
        'nPercentual
        '
        Me.nPercentual.DecimalPlaces = 2
        Me.nPercentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nPercentual.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nPercentual.Location = New System.Drawing.Point(140, 86)
        Me.nPercentual.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nPercentual.Name = "nPercentual"
        Me.nPercentual.Size = New System.Drawing.Size(84, 21)
        Me.nPercentual.TabIndex = 2261
        Me.nPercentual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 2260
        Me.Label5.Text = "Percentual :"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(140, 54)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(242, 21)
        Me.txtDescricao.TabIndex = 1
        '
        'txtCodCusto
        '
        Me.txtCodCusto.Enabled = False
        Me.txtCodCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCusto.Location = New System.Drawing.Point(140, 21)
        Me.txtCodCusto.Name = "txtCodCusto"
        Me.txtCodCusto.Size = New System.Drawing.Size(67, 21)
        Me.txtCodCusto.TabIndex = 2246
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
        'tbCusto
        '
        Me.tbCusto.Controls.Add(Me.tpCadastrar)
        Me.tbCusto.Controls.Add(Me.tpPesquisa)
        Me.tbCusto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCusto.Location = New System.Drawing.Point(0, 67)
        Me.tbCusto.Name = "tbCusto"
        Me.tbCusto.SelectedIndex = 0
        Me.tbCusto.Size = New System.Drawing.Size(778, 267)
        Me.tbCusto.TabIndex = 166
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnFechar)
        Me.Panel2.Controls.Add(Me.btnimprimir)
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
        Me.Panel2.Size = New System.Drawing.Size(778, 67)
        Me.Panel2.TabIndex = 165
        '
        'btnFechar
        '
        Me.btnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFechar.Location = New System.Drawing.Point(660, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(118, 67)
        Me.btnFechar.TabIndex = 161
        Me.btnFechar.Text = "F12 - Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnimprimir.FlatAppearance.BorderSize = 0
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.ForeColor = System.Drawing.Color.Black
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimprimir.Location = New System.Drawing.Point(654, 0)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(118, 67)
        Me.btnimprimir.TabIndex = 160
        Me.btnimprimir.Text = "F6 - Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(632, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(22, 67)
        Me.Panel6.TabIndex = 159
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
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(487, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 67)
        Me.Panel5.TabIndex = 40
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
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(350, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(22, 67)
        Me.Panel4.TabIndex = 38
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
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(229, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 67)
        Me.Panel3.TabIndex = 36
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
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(102, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 67)
        Me.Panel1.TabIndex = 34
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
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GERACUSTOBindingSource
        '
        Me.GERACUSTOBindingSource.DataMember = "GERA_CUSTO"
        Me.GERACUSTOBindingSource.DataSource = Me.DsAmbiente
        '
        'CODGERACUSTODataGridViewTextBoxColumn
        '
        Me.CODGERACUSTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODGERACUSTODataGridViewTextBoxColumn.DataPropertyName = "CODGERACUSTO"
        Me.CODGERACUSTODataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CODGERACUSTODataGridViewTextBoxColumn.Name = "CODGERACUSTODataGridViewTextBoxColumn"
        Me.CODGERACUSTODataGridViewTextBoxColumn.ReadOnly = True
        Me.CODGERACUSTODataGridViewTextBoxColumn.Width = 70
        '
        'DESCRICAODataGridViewTextBoxColumn
        '
        Me.DESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO"
        Me.DESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição"
        Me.DESCRICAODataGridViewTextBoxColumn.Name = "DESCRICAODataGridViewTextBoxColumn"
        Me.DESCRICAODataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCRICAODataGridViewTextBoxColumn.Width = 550
        '
        'PERCENTUALDataGridViewTextBoxColumn
        '
        Me.PERCENTUALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PERCENTUALDataGridViewTextBoxColumn.DataPropertyName = "PERCENTUAL"
        Me.PERCENTUALDataGridViewTextBoxColumn.HeaderText = "Percentual"
        Me.PERCENTUALDataGridViewTextBoxColumn.Name = "PERCENTUALDataGridViewTextBoxColumn"
        Me.PERCENTUALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCadastroCusto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 334)
        Me.Controls.Add(Me.tbCusto)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroCusto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroCusto"
        CType(Me.dg_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.tpCadastrar.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.nPercentual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCusto.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GERACUSTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label27 As Label
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents dg_funcionario As DataGridView
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents Panel7 As Panel
    Public WithEvents nPercentual As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtCodCusto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCusto As TabControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btncancelar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnsalvar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btneditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btninserir As Button
    Friend WithEvents CODGERACUSTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRICAODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PERCENTUALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GERACUSTOBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
End Class
