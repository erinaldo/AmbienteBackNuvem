<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.imgConf = New System.Windows.Forms.PictureBox()
        Me.lblFuncLogado = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.imgCadeadoDesbloqueado = New System.Windows.Forms.PictureBox()
        Me.imgCadeadoBloqueado = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.imgMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCadastros = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCadastroColaborador = New System.Windows.Forms.Button()
        Me.btnMoviementacao = New System.Windows.Forms.Button()
        Me.pCadastros = New System.Windows.Forms.Panel()
        Me.btnEntregador = New System.Windows.Forms.Button()
        Me.btnFormasPagamento = New System.Windows.Forms.Button()
        Me.btnOperadoresCartao = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnCusto = New System.Windows.Forms.Button()
        Me.btnCadastroProdutos = New System.Windows.Forms.Button()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnFuncao = New System.Windows.Forms.Button()
        Me.pMovimentacao = New System.Windows.Forms.Panel()
        Me.btnPendencias = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtualizarPreco = New System.Windows.Forms.Button()
        Me.pImportarProdutos = New System.Windows.Forms.ProgressBar()
        Me.btnImportarProdutos = New System.Windows.Forms.Button()
        Me.btnNotaFiscalEletronica = New System.Windows.Forms.Button()
        Me.btnAgruparPendencia = New System.Windows.Forms.Button()
        Me.btnRelOrcCanceladas = New System.Windows.Forms.Button()
        Me.btnRelOrcVenda = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tImportarProdutos = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgConf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imgCadeadoDesbloqueado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCadeadoBloqueado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pCadastros.SuspendLayout()
        Me.pMovimentacao.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgConf
        '
        Me.imgConf.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgConf.Image = CType(resources.GetObject("imgConf.Image"), System.Drawing.Image)
        Me.imgConf.Location = New System.Drawing.Point(991, 0)
        Me.imgConf.Name = "imgConf"
        Me.imgConf.Size = New System.Drawing.Size(40, 44)
        Me.imgConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgConf.TabIndex = 2
        Me.imgConf.TabStop = False
        '
        'lblFuncLogado
        '
        Me.lblFuncLogado.AutoSize = True
        Me.lblFuncLogado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncLogado.ForeColor = System.Drawing.Color.White
        Me.lblFuncLogado.Location = New System.Drawing.Point(2, 14)
        Me.lblFuncLogado.Name = "lblFuncLogado"
        Me.lblFuncLogado.Size = New System.Drawing.Size(0, 16)
        Me.lblFuncLogado.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(939, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.Controls.Add(Me.lblFuncLogado)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(971, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 44)
        Me.Panel7.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Indigo
        Me.Panel3.Controls.Add(Me.lblMenu)
        Me.Panel3.Controls.Add(Me.imgCadeadoDesbloqueado)
        Me.Panel3.Controls.Add(Me.imgCadeadoBloqueado)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.imgConf)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(269, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1031, 44)
        Me.Panel3.TabIndex = 7
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 7)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(44, 37)
        Me.lblMenu.TabIndex = 14
        Me.lblMenu.Text = "..."
        '
        'imgCadeadoDesbloqueado
        '
        Me.imgCadeadoDesbloqueado.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgCadeadoDesbloqueado.Image = CType(resources.GetObject("imgCadeadoDesbloqueado.Image"), System.Drawing.Image)
        Me.imgCadeadoDesbloqueado.Location = New System.Drawing.Point(817, 0)
        Me.imgCadeadoDesbloqueado.Name = "imgCadeadoDesbloqueado"
        Me.imgCadeadoDesbloqueado.Size = New System.Drawing.Size(48, 44)
        Me.imgCadeadoDesbloqueado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCadeadoDesbloqueado.TabIndex = 13
        Me.imgCadeadoDesbloqueado.TabStop = False
        Me.imgCadeadoDesbloqueado.Visible = False
        '
        'imgCadeadoBloqueado
        '
        Me.imgCadeadoBloqueado.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgCadeadoBloqueado.Image = CType(resources.GetObject("imgCadeadoBloqueado.Image"), System.Drawing.Image)
        Me.imgCadeadoBloqueado.Location = New System.Drawing.Point(865, 0)
        Me.imgCadeadoBloqueado.Name = "imgCadeadoBloqueado"
        Me.imgCadeadoBloqueado.Size = New System.Drawing.Size(48, 44)
        Me.imgCadeadoBloqueado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCadeadoBloqueado.TabIndex = 12
        Me.imgCadeadoBloqueado.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(913, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(26, 44)
        Me.Panel4.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(976, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(15, 44)
        Me.Panel6.TabIndex = 3
        '
        'imgMenu
        '
        Me.imgMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgMenu.Image = CType(resources.GetObject("imgMenu.Image"), System.Drawing.Image)
        Me.imgMenu.Location = New System.Drawing.Point(195, 0)
        Me.imgMenu.Name = "imgMenu"
        Me.imgMenu.Size = New System.Drawing.Size(74, 44)
        Me.imgMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgMenu.TabIndex = 1
        Me.imgMenu.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 873)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(269, 47)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "             Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnCadastros
        '
        Me.btnCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastros.FlatAppearance.BorderSize = 0
        Me.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCadastros.Image = CType(resources.GetObject("btnCadastros.Image"), System.Drawing.Image)
        Me.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastros.Location = New System.Drawing.Point(0, 44)
        Me.btnCadastros.Name = "btnCadastros"
        Me.btnCadastros.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCadastros.Size = New System.Drawing.Size(269, 47)
        Me.btnCadastros.TabIndex = 12
        Me.btnCadastros.Text = "             CADASTROS"
        Me.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastros.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.Controls.Add(Me.imgMenu)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 44)
        Me.Panel2.TabIndex = 0
        '
        'btnCadastroColaborador
        '
        Me.btnCadastroColaborador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastroColaborador.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastroColaborador.FlatAppearance.BorderSize = 0
        Me.btnCadastroColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCadastroColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroColaborador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroColaborador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCadastroColaborador.Image = CType(resources.GetObject("btnCadastroColaborador.Image"), System.Drawing.Image)
        Me.btnCadastroColaborador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastroColaborador.Location = New System.Drawing.Point(0, 0)
        Me.btnCadastroColaborador.Name = "btnCadastroColaborador"
        Me.btnCadastroColaborador.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCadastroColaborador.Size = New System.Drawing.Size(267, 47)
        Me.btnCadastroColaborador.TabIndex = 13
        Me.btnCadastroColaborador.Text = "             Colaboradores"
        Me.btnCadastroColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastroColaborador.UseVisualStyleBackColor = True
        '
        'btnMoviementacao
        '
        Me.btnMoviementacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoviementacao.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMoviementacao.FlatAppearance.BorderSize = 0
        Me.btnMoviementacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnMoviementacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoviementacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoviementacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMoviementacao.Image = CType(resources.GetObject("btnMoviementacao.Image"), System.Drawing.Image)
        Me.btnMoviementacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoviementacao.Location = New System.Drawing.Point(0, 516)
        Me.btnMoviementacao.Name = "btnMoviementacao"
        Me.btnMoviementacao.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMoviementacao.Size = New System.Drawing.Size(269, 47)
        Me.btnMoviementacao.TabIndex = 15
        Me.btnMoviementacao.Text = "             MOVIMENTAÇÃO"
        Me.btnMoviementacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoviementacao.UseVisualStyleBackColor = True
        '
        'pCadastros
        '
        Me.pCadastros.AutoSize = True
        Me.pCadastros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCadastros.Controls.Add(Me.btnEntregador)
        Me.pCadastros.Controls.Add(Me.btnFormasPagamento)
        Me.pCadastros.Controls.Add(Me.btnOperadoresCartao)
        Me.pCadastros.Controls.Add(Me.btnCategoria)
        Me.pCadastros.Controls.Add(Me.btnCusto)
        Me.pCadastros.Controls.Add(Me.btnCadastroProdutos)
        Me.pCadastros.Controls.Add(Me.btnFuncionarios)
        Me.pCadastros.Controls.Add(Me.btnFuncao)
        Me.pCadastros.Controls.Add(Me.btnCadastroColaborador)
        Me.pCadastros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCadastros.Location = New System.Drawing.Point(0, 91)
        Me.pCadastros.Name = "pCadastros"
        Me.pCadastros.Size = New System.Drawing.Size(269, 425)
        Me.pCadastros.TabIndex = 14
        Me.pCadastros.Visible = False
        '
        'btnEntregador
        '
        Me.btnEntregador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregador.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntregador.FlatAppearance.BorderSize = 0
        Me.btnEntregador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEntregador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEntregador.Image = CType(resources.GetObject("btnEntregador.Image"), System.Drawing.Image)
        Me.btnEntregador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregador.Location = New System.Drawing.Point(0, 376)
        Me.btnEntregador.Name = "btnEntregador"
        Me.btnEntregador.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEntregador.Size = New System.Drawing.Size(267, 47)
        Me.btnEntregador.TabIndex = 29
        Me.btnEntregador.Text = "             Entregador"
        Me.btnEntregador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregador.UseVisualStyleBackColor = True
        '
        'btnFormasPagamento
        '
        Me.btnFormasPagamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormasPagamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormasPagamento.FlatAppearance.BorderSize = 0
        Me.btnFormasPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnFormasPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormasPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormasPagamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFormasPagamento.Image = CType(resources.GetObject("btnFormasPagamento.Image"), System.Drawing.Image)
        Me.btnFormasPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormasPagamento.Location = New System.Drawing.Point(0, 329)
        Me.btnFormasPagamento.Name = "btnFormasPagamento"
        Me.btnFormasPagamento.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnFormasPagamento.Size = New System.Drawing.Size(267, 47)
        Me.btnFormasPagamento.TabIndex = 28
        Me.btnFormasPagamento.Text = "             Forma Pagamento"
        Me.btnFormasPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormasPagamento.UseVisualStyleBackColor = True
        '
        'btnOperadoresCartao
        '
        Me.btnOperadoresCartao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOperadoresCartao.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOperadoresCartao.FlatAppearance.BorderSize = 0
        Me.btnOperadoresCartao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnOperadoresCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperadoresCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperadoresCartao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOperadoresCartao.Image = CType(resources.GetObject("btnOperadoresCartao.Image"), System.Drawing.Image)
        Me.btnOperadoresCartao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperadoresCartao.Location = New System.Drawing.Point(0, 282)
        Me.btnOperadoresCartao.Name = "btnOperadoresCartao"
        Me.btnOperadoresCartao.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOperadoresCartao.Size = New System.Drawing.Size(267, 47)
        Me.btnOperadoresCartao.TabIndex = 27
        Me.btnOperadoresCartao.Text = "             Operadores de Cartão"
        Me.btnOperadoresCartao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperadoresCartao.UseVisualStyleBackColor = True
        '
        'btnCategoria
        '
        Me.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategoria.FlatAppearance.BorderSize = 0
        Me.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCategoria.Image = CType(resources.GetObject("btnCategoria.Image"), System.Drawing.Image)
        Me.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoria.Location = New System.Drawing.Point(0, 235)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCategoria.Size = New System.Drawing.Size(267, 47)
        Me.btnCategoria.TabIndex = 26
        Me.btnCategoria.Text = "             Produto Categoria"
        Me.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'btnCusto
        '
        Me.btnCusto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCusto.FlatAppearance.BorderSize = 0
        Me.btnCusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCusto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCusto.Image = CType(resources.GetObject("btnCusto.Image"), System.Drawing.Image)
        Me.btnCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusto.Location = New System.Drawing.Point(0, 188)
        Me.btnCusto.Name = "btnCusto"
        Me.btnCusto.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCusto.Size = New System.Drawing.Size(267, 47)
        Me.btnCusto.TabIndex = 25
        Me.btnCusto.Text = "             Produto Custo"
        Me.btnCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusto.UseVisualStyleBackColor = True
        '
        'btnCadastroProdutos
        '
        Me.btnCadastroProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastroProdutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastroProdutos.FlatAppearance.BorderSize = 0
        Me.btnCadastroProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCadastroProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroProdutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCadastroProdutos.Image = CType(resources.GetObject("btnCadastroProdutos.Image"), System.Drawing.Image)
        Me.btnCadastroProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastroProdutos.Location = New System.Drawing.Point(0, 141)
        Me.btnCadastroProdutos.Name = "btnCadastroProdutos"
        Me.btnCadastroProdutos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCadastroProdutos.Size = New System.Drawing.Size(267, 47)
        Me.btnCadastroProdutos.TabIndex = 24
        Me.btnCadastroProdutos.Text = "             Produtos"
        Me.btnCadastroProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastroProdutos.UseVisualStyleBackColor = True
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFuncionarios.FlatAppearance.BorderSize = 0
        Me.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFuncionarios.Image = CType(resources.GetObject("btnFuncionarios.Image"), System.Drawing.Image)
        Me.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionarios.Location = New System.Drawing.Point(0, 94)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnFuncionarios.Size = New System.Drawing.Size(267, 47)
        Me.btnFuncionarios.TabIndex = 20
        Me.btnFuncionarios.Text = "             Funcionarios"
        Me.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnFuncao
        '
        Me.btnFuncao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFuncao.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFuncao.FlatAppearance.BorderSize = 0
        Me.btnFuncao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFuncao.Image = CType(resources.GetObject("btnFuncao.Image"), System.Drawing.Image)
        Me.btnFuncao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncao.Location = New System.Drawing.Point(0, 47)
        Me.btnFuncao.Name = "btnFuncao"
        Me.btnFuncao.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnFuncao.Size = New System.Drawing.Size(267, 47)
        Me.btnFuncao.TabIndex = 19
        Me.btnFuncao.Text = "             Função"
        Me.btnFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncao.UseVisualStyleBackColor = True
        '
        'pMovimentacao
        '
        Me.pMovimentacao.AutoSize = True
        Me.pMovimentacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMovimentacao.Controls.Add(Me.btnPendencias)
        Me.pMovimentacao.Dock = System.Windows.Forms.DockStyle.Top
        Me.pMovimentacao.Location = New System.Drawing.Point(0, 563)
        Me.pMovimentacao.Name = "pMovimentacao"
        Me.pMovimentacao.Size = New System.Drawing.Size(269, 49)
        Me.pMovimentacao.TabIndex = 16
        Me.pMovimentacao.Visible = False
        '
        'btnPendencias
        '
        Me.btnPendencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPendencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPendencias.FlatAppearance.BorderSize = 0
        Me.btnPendencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnPendencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPendencias.Image = CType(resources.GetObject("btnPendencias.Image"), System.Drawing.Image)
        Me.btnPendencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPendencias.Location = New System.Drawing.Point(0, 0)
        Me.btnPendencias.Name = "btnPendencias"
        Me.btnPendencias.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnPendencias.Size = New System.Drawing.Size(267, 47)
        Me.btnPendencias.TabIndex = 21
        Me.btnPendencias.Text = "             Dabito Geral"
        Me.btnPendencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPendencias.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAtualizarPreco)
        Me.Panel1.Controls.Add(Me.pImportarProdutos)
        Me.Panel1.Controls.Add(Me.btnImportarProdutos)
        Me.Panel1.Controls.Add(Me.btnNotaFiscalEletronica)
        Me.Panel1.Controls.Add(Me.btnAgruparPendencia)
        Me.Panel1.Controls.Add(Me.btnRelOrcCanceladas)
        Me.Panel1.Controls.Add(Me.btnRelOrcVenda)
        Me.Panel1.Controls.Add(Me.pMovimentacao)
        Me.Panel1.Controls.Add(Me.btnMoviementacao)
        Me.Panel1.Controls.Add(Me.pCadastros)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnCadastros)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 920)
        Me.Panel1.TabIndex = 6
        '
        'btnAtualizarPreco
        '
        Me.btnAtualizarPreco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtualizarPreco.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAtualizarPreco.FlatAppearance.BorderSize = 0
        Me.btnAtualizarPreco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAtualizarPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizarPreco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAtualizarPreco.Image = CType(resources.GetObject("btnAtualizarPreco.Image"), System.Drawing.Image)
        Me.btnAtualizarPreco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizarPreco.Location = New System.Drawing.Point(0, 862)
        Me.btnAtualizarPreco.Name = "btnAtualizarPreco"
        Me.btnAtualizarPreco.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAtualizarPreco.Size = New System.Drawing.Size(269, 53)
        Me.btnAtualizarPreco.TabIndex = 45
        Me.btnAtualizarPreco.Text = "             Atualizar Preços"
        Me.btnAtualizarPreco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizarPreco.UseVisualStyleBackColor = False
        '
        'pImportarProdutos
        '
        Me.pImportarProdutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pImportarProdutos.Location = New System.Drawing.Point(0, 847)
        Me.pImportarProdutos.Name = "pImportarProdutos"
        Me.pImportarProdutos.Size = New System.Drawing.Size(269, 15)
        Me.pImportarProdutos.TabIndex = 44
        Me.pImportarProdutos.Visible = False
        '
        'btnImportarProdutos
        '
        Me.btnImportarProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportarProdutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImportarProdutos.FlatAppearance.BorderSize = 0
        Me.btnImportarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnImportarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportarProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarProdutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnImportarProdutos.Image = CType(resources.GetObject("btnImportarProdutos.Image"), System.Drawing.Image)
        Me.btnImportarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarProdutos.Location = New System.Drawing.Point(0, 800)
        Me.btnImportarProdutos.Name = "btnImportarProdutos"
        Me.btnImportarProdutos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnImportarProdutos.Size = New System.Drawing.Size(269, 47)
        Me.btnImportarProdutos.TabIndex = 43
        Me.btnImportarProdutos.Text = "             Importar Produtos"
        Me.btnImportarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarProdutos.UseVisualStyleBackColor = False
        '
        'btnNotaFiscalEletronica
        '
        Me.btnNotaFiscalEletronica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotaFiscalEletronica.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNotaFiscalEletronica.FlatAppearance.BorderSize = 0
        Me.btnNotaFiscalEletronica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnNotaFiscalEletronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotaFiscalEletronica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotaFiscalEletronica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNotaFiscalEletronica.Image = CType(resources.GetObject("btnNotaFiscalEletronica.Image"), System.Drawing.Image)
        Me.btnNotaFiscalEletronica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaFiscalEletronica.Location = New System.Drawing.Point(0, 753)
        Me.btnNotaFiscalEletronica.Name = "btnNotaFiscalEletronica"
        Me.btnNotaFiscalEletronica.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnNotaFiscalEletronica.Size = New System.Drawing.Size(269, 47)
        Me.btnNotaFiscalEletronica.TabIndex = 42
        Me.btnNotaFiscalEletronica.Text = "             Nota Fiscal Eletronica"
        Me.btnNotaFiscalEletronica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaFiscalEletronica.UseVisualStyleBackColor = True
        Me.btnNotaFiscalEletronica.Visible = False
        '
        'btnAgruparPendencia
        '
        Me.btnAgruparPendencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgruparPendencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgruparPendencia.FlatAppearance.BorderSize = 0
        Me.btnAgruparPendencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAgruparPendencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparPendencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgruparPendencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgruparPendencia.Image = CType(resources.GetObject("btnAgruparPendencia.Image"), System.Drawing.Image)
        Me.btnAgruparPendencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgruparPendencia.Location = New System.Drawing.Point(0, 706)
        Me.btnAgruparPendencia.Name = "btnAgruparPendencia"
        Me.btnAgruparPendencia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAgruparPendencia.Size = New System.Drawing.Size(269, 47)
        Me.btnAgruparPendencia.TabIndex = 41
        Me.btnAgruparPendencia.Text = "             Agrupar Pendências"
        Me.btnAgruparPendencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgruparPendencia.UseVisualStyleBackColor = True
        Me.btnAgruparPendencia.Visible = False
        '
        'btnRelOrcCanceladas
        '
        Me.btnRelOrcCanceladas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelOrcCanceladas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRelOrcCanceladas.FlatAppearance.BorderSize = 0
        Me.btnRelOrcCanceladas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnRelOrcCanceladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelOrcCanceladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelOrcCanceladas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRelOrcCanceladas.Image = CType(resources.GetObject("btnRelOrcCanceladas.Image"), System.Drawing.Image)
        Me.btnRelOrcCanceladas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelOrcCanceladas.Location = New System.Drawing.Point(0, 659)
        Me.btnRelOrcCanceladas.Name = "btnRelOrcCanceladas"
        Me.btnRelOrcCanceladas.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRelOrcCanceladas.Size = New System.Drawing.Size(269, 47)
        Me.btnRelOrcCanceladas.TabIndex = 40
        Me.btnRelOrcCanceladas.Text = "             Orc/Venda Cancelados"
        Me.btnRelOrcCanceladas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelOrcCanceladas.UseVisualStyleBackColor = True
        '
        'btnRelOrcVenda
        '
        Me.btnRelOrcVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelOrcVenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRelOrcVenda.FlatAppearance.BorderSize = 0
        Me.btnRelOrcVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnRelOrcVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelOrcVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelOrcVenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRelOrcVenda.Image = CType(resources.GetObject("btnRelOrcVenda.Image"), System.Drawing.Image)
        Me.btnRelOrcVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelOrcVenda.Location = New System.Drawing.Point(0, 612)
        Me.btnRelOrcVenda.Name = "btnRelOrcVenda"
        Me.btnRelOrcVenda.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRelOrcVenda.Size = New System.Drawing.Size(269, 47)
        Me.btnRelOrcVenda.TabIndex = 28
        Me.btnRelOrcVenda.Text = "             Relatório de Orc/Venda"
        Me.btnRelOrcVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelOrcVenda.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.AutoSize = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(269, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1031, 876)
        Me.Panel5.TabIndex = 8
        '
        'tImportarProdutos
        '
        Me.tImportarProdutos.Interval = 1000
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1300, 920)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgConf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imgCadeadoDesbloqueado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCadeadoBloqueado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pCadastros.ResumeLayout(False)
        Me.pMovimentacao.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgConf As PictureBox
    Friend WithEvents lblFuncLogado As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents imgMenu As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCadastros As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCadastroColaborador As Button
    Friend WithEvents btnMoviementacao As Button
    Friend WithEvents pCadastros As Panel
    Friend WithEvents pMovimentacao As Panel
    Friend WithEvents btnPendencias As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOperadoresCartao As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents btnCusto As Button
    Friend WithEvents btnCadastroProdutos As Button
    Friend WithEvents btnFuncionarios As Button
    Friend WithEvents btnFuncao As Button
    Friend WithEvents btnFormasPagamento As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRelOrcVenda As Button
    Friend WithEvents btnEntregador As Button
    Friend WithEvents tImportarProdutos As Timer
    Friend WithEvents btnAtualizarPreco As Button
    Friend WithEvents pImportarProdutos As ProgressBar
    Friend WithEvents btnImportarProdutos As Button
    Friend WithEvents btnNotaFiscalEletronica As Button
    Friend WithEvents btnAgruparPendencia As Button
    Friend WithEvents btnRelOrcCanceladas As Button
    Friend WithEvents imgCadeadoBloqueado As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents imgCadeadoDesbloqueado As PictureBox
End Class
