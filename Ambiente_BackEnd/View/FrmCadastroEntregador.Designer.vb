<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadastroEntregador
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroEntregador))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbxAtivo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbEntregador = New System.Windows.Forms.TabControl()
        Me.tpCadastrar = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodEntregador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.dgEntregador = New System.Windows.Forms.DataGridView()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.ENTREGADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODENTREGADORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.tbEntregador.SuspendLayout()
        Me.tpCadastrar.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        CType(Me.dgEntregador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTREGADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.TabIndex = 214
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
        Me.Panel8.TabIndex = 215
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
        'tbEntregador
        '
        Me.tbEntregador.Controls.Add(Me.tpCadastrar)
        Me.tbEntregador.Controls.Add(Me.tpPesquisa)
        Me.tbEntregador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEntregador.Location = New System.Drawing.Point(0, 67)
        Me.tbEntregador.Name = "tbEntregador"
        Me.tbEntregador.SelectedIndex = 0
        Me.tbEntregador.Size = New System.Drawing.Size(784, 264)
        Me.tbEntregador.TabIndex = 216
        '
        'tpCadastrar
        '
        Me.tpCadastrar.Controls.Add(Me.Panel7)
        Me.tpCadastrar.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastrar.Name = "tpCadastrar"
        Me.tpCadastrar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastrar.Size = New System.Drawing.Size(776, 238)
        Me.tpCadastrar.TabIndex = 0
        Me.tpCadastrar.Text = "Cadastrar Entregador"
        Me.tpCadastrar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.txtTelefone)
        Me.Panel7.Controls.Add(Me.txtEmpresa)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.txtNome)
        Me.Panel7.Controls.Add(Me.txtCodEntregador)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(770, 232)
        Me.Panel7.TabIndex = 159
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(140, 54)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(242, 21)
        Me.txtNome.TabIndex = 1
        '
        'txtCodEntregador
        '
        Me.txtCodEntregador.Enabled = False
        Me.txtCodEntregador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEntregador.Location = New System.Drawing.Point(140, 21)
        Me.txtCodEntregador.Name = "txtCodEntregador"
        Me.txtCodEntregador.Size = New System.Drawing.Size(67, 21)
        Me.txtCodEntregador.TabIndex = 2246
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(77, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 2248
        Me.Label2.Text = "Nome :"
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
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label27)
        Me.tpPesquisa.Controls.Add(Me.cbxFiltro)
        Me.tpPesquisa.Controls.Add(Me.Label26)
        Me.tpPesquisa.Controls.Add(Me.txtPesquisar)
        Me.tpPesquisa.Controls.Add(Me.dgEntregador)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPesquisa.Size = New System.Drawing.Size(776, 238)
        Me.tpPesquisa.TabIndex = 1
        Me.tpPesquisa.Text = "Pesquisar Entregador"
        Me.tpPesquisa.UseVisualStyleBackColor = True
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
        'dgEntregador
        '
        Me.dgEntregador.AllowUserToAddRows = False
        Me.dgEntregador.AllowUserToDeleteRows = False
        Me.dgEntregador.AutoGenerateColumns = False
        Me.dgEntregador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEntregador.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgEntregador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEntregador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEntregador.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgEntregador.ColumnHeadersHeight = 20
        Me.dgEntregador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODENTREGADORDataGridViewTextBoxColumn, Me.NOMEDataGridViewTextBoxColumn, Me.EMPRESADataGridViewTextBoxColumn, Me.TELEFONEDataGridViewTextBoxColumn, Me.ATIVODataGridViewTextBoxColumn})
        Me.dgEntregador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgEntregador.DataSource = Me.ENTREGADORBindingSource
        Me.dgEntregador.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgEntregador.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgEntregador.Location = New System.Drawing.Point(3, 56)
        Me.dgEntregador.Name = "dgEntregador"
        Me.dgEntregador.ReadOnly = True
        Me.dgEntregador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEntregador.Size = New System.Drawing.Size(770, 179)
        Me.dgEntregador.TabIndex = 48
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(141, 81)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(242, 21)
        Me.txtEmpresa.TabIndex = 2249
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 2250
        Me.Label1.Text = "Empresa :"
        '
        'txtTelefone
        '
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(140, 108)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(116, 21)
        Me.txtTelefone.TabIndex = 2252
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(61, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 2253
        Me.Label3.Text = "Telefone :"
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ENTREGADORBindingSource
        '
        Me.ENTREGADORBindingSource.DataMember = "ENTREGADOR"
        Me.ENTREGADORBindingSource.DataSource = Me.DsAmbiente
        '
        'CODENTREGADORDataGridViewTextBoxColumn
        '
        Me.CODENTREGADORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODENTREGADORDataGridViewTextBoxColumn.DataPropertyName = "CODENTREGADOR"
        Me.CODENTREGADORDataGridViewTextBoxColumn.HeaderText = "Codigo Entregador"
        Me.CODENTREGADORDataGridViewTextBoxColumn.Name = "CODENTREGADORDataGridViewTextBoxColumn"
        Me.CODENTREGADORDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODENTREGADORDataGridViewTextBoxColumn.Width = 110
        '
        'NOMEDataGridViewTextBoxColumn
        '
        Me.NOMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NOMEDataGridViewTextBoxColumn.Name = "NOMEDataGridViewTextBoxColumn"
        Me.NOMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMEDataGridViewTextBoxColumn.Width = 200
        '
        'EMPRESADataGridViewTextBoxColumn
        '
        Me.EMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA"
        Me.EMPRESADataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EMPRESADataGridViewTextBoxColumn.Name = "EMPRESADataGridViewTextBoxColumn"
        Me.EMPRESADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONEDataGridViewTextBoxColumn
        '
        Me.TELEFONEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE"
        Me.TELEFONEDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TELEFONEDataGridViewTextBoxColumn.Name = "TELEFONEDataGridViewTextBoxColumn"
        Me.TELEFONEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TELEFONEDataGridViewTextBoxColumn.Width = 110
        '
        'ATIVODataGridViewTextBoxColumn
        '
        Me.ATIVODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ATIVODataGridViewTextBoxColumn.DataPropertyName = "ATIVO"
        Me.ATIVODataGridViewTextBoxColumn.HeaderText = "Ativo"
        Me.ATIVODataGridViewTextBoxColumn.Name = "ATIVODataGridViewTextBoxColumn"
        Me.ATIVODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCadastroEntregador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 371)
        Me.Controls.Add(Me.tbEntregador)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadastroEntregador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroEntregador"
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.tbEntregador.ResumeLayout(False)
        Me.tpCadastrar.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        CType(Me.dgEntregador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTREGADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFechar As Button
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
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbxAtivo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbEntregador As TabControl
    Friend WithEvents tpCadastrar As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodEntregador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxFiltro As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtPesquisar As TextBox
    Friend WithEvents dgEntregador As DataGridView
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents CODENTREGADORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPRESADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ATIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTREGADORBindingSource As BindingSource
    Friend WithEvents DsAmbiente As dsAmbiente
End Class
