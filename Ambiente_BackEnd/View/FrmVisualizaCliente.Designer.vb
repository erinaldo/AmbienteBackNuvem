<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisualizaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisualizaCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefoneCelular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCpfCnpj = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInscEstadual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCodigoIbge = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAtualizarDados = New System.Windows.Forms.Button()
        Me.lblvalida = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(375, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dados do Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo :"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Location = New System.Drawing.Point(464, 105)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigoCliente.TabIndex = 2
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Location = New System.Drawing.Point(464, 171)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(400, 20)
        Me.txtRazaoSocial.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Razão Social :"
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.Location = New System.Drawing.Point(464, 197)
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.Size = New System.Drawing.Size(400, 20)
        Me.txtNomeFantasia.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome Fantasia :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Telefone / Celular :"
        '
        'txtTelefoneCelular
        '
        Me.txtTelefoneCelular.Location = New System.Drawing.Point(464, 223)
        Me.txtTelefoneCelular.Name = "txtTelefoneCelular"
        Me.txtTelefoneCelular.Size = New System.Drawing.Size(143, 20)
        Me.txtTelefoneCelular.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Email :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(464, 249)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.Location = New System.Drawing.Point(464, 131)
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Size = New System.Drawing.Size(143, 20)
        Me.txtCpfCnpj.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "CPF / CNPJ :"
        '
        'txtInscEstadual
        '
        Me.txtInscEstadual.Location = New System.Drawing.Point(464, 274)
        Me.txtInscEstadual.Name = "txtInscEstadual"
        Me.txtInscEstadual.Size = New System.Drawing.Size(143, 20)
        Me.txtInscEstadual.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Insc. Estadual :"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(465, 300)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(143, 20)
        Me.txtCep.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(421, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "CEP :"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(465, 326)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(296, 20)
        Me.txtEndereco.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Endereço :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(767, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Nº :"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(802, 326)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(63, 20)
        Me.txtNumero.TabIndex = 20
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(465, 352)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(166, 20)
        Me.txtBairro.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(412, 353)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Bairro :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(637, 353)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Cidade :"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(700, 352)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(165, 20)
        Me.txtCidade.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(551, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Codigo IBGE :"
        '
        'txtCodigoIbge
        '
        Me.txtCodigoIbge.Location = New System.Drawing.Point(648, 378)
        Me.txtCodigoIbge.Name = "txtCodigoIbge"
        Me.txtCodigoIbge.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigoIbge.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(430, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 16)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "UF :"
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(465, 378)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(80, 20)
        Me.txtUf.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(374, 404)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 16)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Codigo Pais :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(465, 403)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 279)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(727, 425)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(138, 45)
        Me.btnConfirmar.TabIndex = 32
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnAtualizarDados
        '
        Me.btnAtualizarDados.Image = CType(resources.GetObject("btnAtualizarDados.Image"), System.Drawing.Image)
        Me.btnAtualizarDados.Location = New System.Drawing.Point(583, 425)
        Me.btnAtualizarDados.Name = "btnAtualizarDados"
        Me.btnAtualizarDados.Size = New System.Drawing.Size(138, 45)
        Me.btnAtualizarDados.TabIndex = 33
        Me.btnAtualizarDados.Text = "Atualizar Dados"
        Me.btnAtualizarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAtualizarDados.UseVisualStyleBackColor = True
        '
        'lblvalida
        '
        Me.lblvalida.AutoSize = True
        Me.lblvalida.Location = New System.Drawing.Point(465, 154)
        Me.lblvalida.Name = "lblvalida"
        Me.lblvalida.Size = New System.Drawing.Size(22, 13)
        Me.lblvalida.TabIndex = 202
        Me.lblvalida.Text = "....."
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(610, 131)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(64, 20)
        Me.btnValidar.TabIndex = 203
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'FrmVisualizaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 482)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.lblvalida)
        Me.Controls.Add(Me.btnAtualizarDados)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCodigoIbge)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInscEstadual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCpfCnpj)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefoneCelular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomeFantasia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRazaoSocial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmVisualizaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeFantasia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefoneCelular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCpfCnpj As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInscEstadual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCep As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCodigoIbge As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtUf As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnAtualizarDados As Button
    Friend WithEvents lblvalida As Label
    Friend WithEvents btnValidar As Button
End Class
