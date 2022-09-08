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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.txtDescricaoNcm = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtCodigoNcm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescricaCest = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtCodigoCest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescricaoCfop = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtCodigoCfop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nValorUnit = New System.Windows.Forms.NumericUpDown()
        Me.nValorTotal = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nValorUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nValorTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lançamento de Itens"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Produto :"
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Enabled = False
        Me.txtNomeProduto.Location = New System.Drawing.Point(242, 71)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(310, 20)
        Me.txtNomeProduto.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(211, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Location = New System.Drawing.Point(134, 71)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(76, 20)
        Me.txtCodProduto.TabIndex = 0
        '
        'txtDescricaoNcm
        '
        Me.txtDescricaoNcm.Enabled = False
        Me.txtDescricaoNcm.Location = New System.Drawing.Point(242, 97)
        Me.txtDescricaoNcm.Name = "txtDescricaoNcm"
        Me.txtDescricaoNcm.Size = New System.Drawing.Size(310, 20)
        Me.txtDescricaoNcm.TabIndex = 52
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(211, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'txtCodigoNcm
        '
        Me.txtCodigoNcm.Location = New System.Drawing.Point(134, 97)
        Me.txtCodigoNcm.Name = "txtCodigoNcm"
        Me.txtCodigoNcm.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoNcm.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Código NCM :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Código CEST :"
        '
        'txtDescricaCest
        '
        Me.txtDescricaCest.Enabled = False
        Me.txtDescricaCest.Location = New System.Drawing.Point(242, 123)
        Me.txtDescricaCest.Name = "txtDescricaCest"
        Me.txtDescricaCest.Size = New System.Drawing.Size(310, 20)
        Me.txtDescricaCest.TabIndex = 56
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(211, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'txtCodigoCest
        '
        Me.txtCodigoCest.Location = New System.Drawing.Point(134, 123)
        Me.txtCodigoCest.Name = "txtCodigoCest"
        Me.txtCodigoCest.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoCest.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Código CFOP :"
        '
        'txtDescricaoCfop
        '
        Me.txtDescricaoCfop.Enabled = False
        Me.txtDescricaoCfop.Location = New System.Drawing.Point(242, 149)
        Me.txtDescricaoCfop.Name = "txtDescricaoCfop"
        Me.txtDescricaoCfop.Size = New System.Drawing.Size(310, 20)
        Me.txtDescricaoCfop.TabIndex = 60
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(211, 145)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 59
        Me.PictureBox4.TabStop = False
        '
        'txtCodigoCfop
        '
        Me.txtCodigoCfop.Location = New System.Drawing.Point(134, 149)
        Me.txtCodigoCfop.Name = "txtCodigoCfop"
        Me.txtCodigoCfop.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigoCfop.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Quantidade :"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(134, 175)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(76, 20)
        Me.txtQuantidade.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Valor Unit. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Valor Total :"
        '
        'nValorUnit
        '
        Me.nValorUnit.DecimalPlaces = 2
        Me.nValorUnit.Location = New System.Drawing.Point(304, 176)
        Me.nValorUnit.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nValorUnit.Name = "nValorUnit"
        Me.nValorUnit.Size = New System.Drawing.Size(76, 20)
        Me.nValorUnit.TabIndex = 5
        Me.nValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nValorTotal
        '
        Me.nValorTotal.DecimalPlaces = 2
        Me.nValorTotal.Enabled = False
        Me.nValorTotal.Location = New System.Drawing.Point(476, 176)
        Me.nValorTotal.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nValorTotal.Name = "nValorTotal"
        Me.nValorTotal.Size = New System.Drawing.Size(76, 20)
        Me.nValorTotal.TabIndex = 6
        Me.nValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnConfirmar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 226)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 54)
        Me.Panel2.TabIndex = 68
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 54)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar (F4)"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(449, 0)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(130, 54)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar (F3)"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'FrmLancarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 280)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.nValorTotal)
        Me.Controls.Add(Me.nValorUnit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescricaoCfop)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtCodigoCfop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescricaCest)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtCodigoCest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescricaoNcm)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCodigoNcm)
        Me.Controls.Add(Me.txtNomeProduto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLancarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançar Produto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nValorUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nValorTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCodProduto As TextBox
    Friend WithEvents txtDescricaoNcm As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCodigoNcm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescricaCest As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtCodigoCest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescricaoCfop As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtCodigoCfop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nValorUnit As NumericUpDown
    Friend WithEvents nValorTotal As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
End Class
