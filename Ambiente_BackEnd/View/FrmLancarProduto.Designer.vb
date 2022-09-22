<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLancarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLancarProduto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPrincipal = New System.Windows.Forms.TabPage()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtCsosn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodigoCsosn = New System.Windows.Forms.TextBox()
        Me.nValorTotal = New System.Windows.Forms.NumericUpDown()
        Me.nValorUnitario = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.txtCfop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoCfop = New System.Windows.Forms.TextBox()
        Me.txtCest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoCest = New System.Windows.Forms.TextBox()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoNCM = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpPrincipal.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nValorTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nValorUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(278, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lançamento de Itens"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnConfirmar)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 393)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 57)
        Me.Panel2.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(14, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(129, 57)
        Me.btnCancelar.TabIndex = 81
        Me.btnCancelar.Text = "Cancelar (F4)"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(657, 0)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(129, 57)
        Me.btnConfirmar.TabIndex = 80
        Me.btnConfirmar.Text = "Confirmar (F3)"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(786, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(14, 57)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 57)
        Me.Panel3.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpPrincipal)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 343)
        Me.TabControl1.TabIndex = 3
        '
        'tpPrincipal
        '
        Me.tpPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.tpPrincipal.Controls.Add(Me.txtQuantidade)
        Me.tpPrincipal.Controls.Add(Me.PictureBox4)
        Me.tpPrincipal.Controls.Add(Me.txtCsosn)
        Me.tpPrincipal.Controls.Add(Me.Label10)
        Me.tpPrincipal.Controls.Add(Me.txtCodigoCsosn)
        Me.tpPrincipal.Controls.Add(Me.nValorTotal)
        Me.tpPrincipal.Controls.Add(Me.nValorUnitario)
        Me.tpPrincipal.Controls.Add(Me.Label11)
        Me.tpPrincipal.Controls.Add(Me.Label9)
        Me.tpPrincipal.Controls.Add(Me.Label8)
        Me.tpPrincipal.Controls.Add(Me.PictureBox3)
        Me.tpPrincipal.Controls.Add(Me.PictureBox2)
        Me.tpPrincipal.Controls.Add(Me.PictureBox1)
        Me.tpPrincipal.Controls.Add(Me.PictureBox5)
        Me.tpPrincipal.Controls.Add(Me.Label7)
        Me.tpPrincipal.Controls.Add(Me.Label6)
        Me.tpPrincipal.Controls.Add(Me.txtUnidade)
        Me.tpPrincipal.Controls.Add(Me.txtCfop)
        Me.tpPrincipal.Controls.Add(Me.Label5)
        Me.tpPrincipal.Controls.Add(Me.txtCodigoCfop)
        Me.tpPrincipal.Controls.Add(Me.txtCest)
        Me.tpPrincipal.Controls.Add(Me.Label3)
        Me.tpPrincipal.Controls.Add(Me.txtCodigoCest)
        Me.tpPrincipal.Controls.Add(Me.txtNCM)
        Me.tpPrincipal.Controls.Add(Me.Label2)
        Me.tpPrincipal.Controls.Add(Me.txtCodigoNCM)
        Me.tpPrincipal.Controls.Add(Me.txtNomeProduto)
        Me.tpPrincipal.Controls.Add(Me.Label1)
        Me.tpPrincipal.Controls.Add(Me.txtCodigoProduto)
        Me.tpPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.tpPrincipal.Name = "tpPrincipal"
        Me.tpPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPrincipal.Size = New System.Drawing.Size(792, 317)
        Me.tpPrincipal.TabIndex = 0
        Me.tpPrincipal.Text = "Principal"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(152, 185)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(101, 20)
        Me.txtQuantidade.TabIndex = 0
        Me.txtQuantidade.Text = "0,000"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(255, 127)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'txtCsosn
        '
        Me.txtCsosn.Enabled = False
        Me.txtCsosn.Location = New System.Drawing.Point(288, 132)
        Me.txtCsosn.Name = "txtCsosn"
        Me.txtCsosn.Size = New System.Drawing.Size(315, 20)
        Me.txtCsosn.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Código CSOSN :"
        '
        'txtCodigoCsosn
        '
        Me.txtCodigoCsosn.Location = New System.Drawing.Point(152, 132)
        Me.txtCodigoCsosn.Name = "txtCodigoCsosn"
        Me.txtCodigoCsosn.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoCsosn.TabIndex = 6
        '
        'nValorTotal
        '
        Me.nValorTotal.DecimalPlaces = 2
        Me.nValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nValorTotal.Location = New System.Drawing.Point(279, 229)
        Me.nValorTotal.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nValorTotal.Name = "nValorTotal"
        Me.nValorTotal.Size = New System.Drawing.Size(101, 22)
        Me.nValorTotal.TabIndex = 58
        Me.nValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nValorUnitario
        '
        Me.nValorUnitario.DecimalPlaces = 2
        Me.nValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nValorUnitario.Location = New System.Drawing.Point(152, 229)
        Me.nValorUnitario.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nValorUnitario.Name = "nValorUnitario"
        Me.nValorUnitario.Size = New System.Drawing.Size(101, 22)
        Me.nValorUnitario.TabIndex = 1
        Me.nValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(285, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Total (R$)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Unitário"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(83, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Valores :"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(255, 101)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(255, 75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(255, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(255, 23)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Quantidade :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Unidade :"
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(152, 159)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(101, 20)
        Me.txtUnidade.TabIndex = 7
        '
        'txtCfop
        '
        Me.txtCfop.Enabled = False
        Me.txtCfop.Location = New System.Drawing.Point(288, 106)
        Me.txtCfop.Name = "txtCfop"
        Me.txtCfop.Size = New System.Drawing.Size(315, 20)
        Me.txtCfop.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Código CFOP :"
        '
        'txtCodigoCfop
        '
        Me.txtCodigoCfop.Location = New System.Drawing.Point(152, 106)
        Me.txtCodigoCfop.Name = "txtCodigoCfop"
        Me.txtCodigoCfop.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoCfop.TabIndex = 5
        '
        'txtCest
        '
        Me.txtCest.Enabled = False
        Me.txtCest.Location = New System.Drawing.Point(288, 80)
        Me.txtCest.Name = "txtCest"
        Me.txtCest.Size = New System.Drawing.Size(315, 20)
        Me.txtCest.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Código CEST :"
        '
        'txtCodigoCest
        '
        Me.txtCodigoCest.Location = New System.Drawing.Point(152, 80)
        Me.txtCodigoCest.Name = "txtCodigoCest"
        Me.txtCodigoCest.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoCest.TabIndex = 4
        '
        'txtNCM
        '
        Me.txtNCM.Enabled = False
        Me.txtNCM.Location = New System.Drawing.Point(288, 54)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(315, 20)
        Me.txtNCM.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código NCM :"
        '
        'txtCodigoNCM
        '
        Me.txtCodigoNCM.Location = New System.Drawing.Point(152, 54)
        Me.txtCodigoNCM.Name = "txtCodigoNCM"
        Me.txtCodigoNCM.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoNCM.TabIndex = 3
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Enabled = False
        Me.txtNomeProduto.Location = New System.Drawing.Point(288, 28)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(315, 20)
        Me.txtNomeProduto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Produto :"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Location = New System.Drawing.Point(152, 28)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoProduto.TabIndex = 2
        '
        'FrmLancarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "FrmLancarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançar Produto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpPrincipal.ResumeLayout(False)
        Me.tpPrincipal.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nValorTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nValorUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpPrincipal As TabPage
    Friend WithEvents txtCodigoProduto As TextBox
    Friend WithEvents txtNCM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoNCM As TextBox
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents txtCfop As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigoCfop As TextBox
    Friend WithEvents txtCest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoCest As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nValorTotal As NumericUpDown
    Friend WithEvents nValorUnitario As NumericUpDown
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtCsosn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCodigoCsosn As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
End Class
