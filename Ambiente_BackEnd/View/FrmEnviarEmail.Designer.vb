<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviarEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnviarEmail))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAnexar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.imgXML = New System.Windows.Forms.PictureBox()
        Me.imgPDF = New System.Windows.Forms.PictureBox()
        Me.lblAnexoXml = New System.Windows.Forms.Label()
        Me.lblAnexoPdf = New System.Windows.Forms.Label()
        Me.lblAnexoBoleto = New System.Windows.Forms.Label()
        Me.imgBoleto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgXML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(412, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enviar NF-e por E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Para:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(184, 148)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(685, 29)
        Me.txtEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Assunto:"
        '
        'txtAssunto
        '
        Me.txtAssunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssunto.Location = New System.Drawing.Point(184, 182)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(685, 29)
        Me.txtAssunto.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(184, 226)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(685, 107)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mensagem:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Anexos:"
        '
        'btnAnexar
        '
        Me.btnAnexar.BackColor = System.Drawing.Color.DimGray
        Me.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnexar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnexar.ForeColor = System.Drawing.Color.White
        Me.btnAnexar.Location = New System.Drawing.Point(356, 431)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(121, 43)
        Me.btnAnexar.TabIndex = 9
        Me.btnAnexar.Text = "Anexar"
        Me.btnAnexar.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(483, 431)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(121, 43)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'imgXML
        '
        Me.imgXML.Image = CType(resources.GetObject("imgXML.Image"), System.Drawing.Image)
        Me.imgXML.Location = New System.Drawing.Point(274, 359)
        Me.imgXML.Name = "imgXML"
        Me.imgXML.Size = New System.Drawing.Size(52, 48)
        Me.imgXML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgXML.TabIndex = 11
        Me.imgXML.TabStop = False
        '
        'imgPDF
        '
        Me.imgPDF.Image = CType(resources.GetObject("imgPDF.Image"), System.Drawing.Image)
        Me.imgPDF.Location = New System.Drawing.Point(446, 359)
        Me.imgPDF.Name = "imgPDF"
        Me.imgPDF.Size = New System.Drawing.Size(52, 48)
        Me.imgPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPDF.TabIndex = 12
        Me.imgPDF.TabStop = False
        '
        'lblAnexoXml
        '
        Me.lblAnexoXml.AutoSize = True
        Me.lblAnexoXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexoXml.Location = New System.Drawing.Point(332, 375)
        Me.lblAnexoXml.Name = "lblAnexoXml"
        Me.lblAnexoXml.Size = New System.Drawing.Size(45, 20)
        Me.lblAnexoXml.TabIndex = 13
        Me.lblAnexoXml.Text = "XML"
        '
        'lblAnexoPdf
        '
        Me.lblAnexoPdf.AutoSize = True
        Me.lblAnexoPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexoPdf.Location = New System.Drawing.Point(504, 375)
        Me.lblAnexoPdf.Name = "lblAnexoPdf"
        Me.lblAnexoPdf.Size = New System.Drawing.Size(44, 20)
        Me.lblAnexoPdf.TabIndex = 14
        Me.lblAnexoPdf.Text = "PDF"
        '
        'lblAnexoBoleto
        '
        Me.lblAnexoBoleto.AutoSize = True
        Me.lblAnexoBoleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnexoBoleto.Location = New System.Drawing.Point(675, 375)
        Me.lblAnexoBoleto.Name = "lblAnexoBoleto"
        Me.lblAnexoBoleto.Size = New System.Drawing.Size(79, 20)
        Me.lblAnexoBoleto.TabIndex = 16
        Me.lblAnexoBoleto.Text = "BOLETO"
        '
        'imgBoleto
        '
        Me.imgBoleto.Image = CType(resources.GetObject("imgBoleto.Image"), System.Drawing.Image)
        Me.imgBoleto.Location = New System.Drawing.Point(615, 359)
        Me.imgBoleto.Name = "imgBoleto"
        Me.imgBoleto.Size = New System.Drawing.Size(52, 48)
        Me.imgBoleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBoleto.TabIndex = 15
        Me.imgBoleto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmEnviarEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(923, 496)
        Me.Controls.Add(Me.lblAnexoBoleto)
        Me.Controls.Add(Me.imgBoleto)
        Me.Controls.Add(Me.lblAnexoPdf)
        Me.Controls.Add(Me.lblAnexoXml)
        Me.Controls.Add(Me.imgPDF)
        Me.Controls.Add(Me.imgXML)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnAnexar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmEnviarEmail"
        Me.Text = "FrmEnviarEmail"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgXML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAssunto As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAnexar As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents imgPDF As PictureBox
    Friend WithEvents imgXML As PictureBox
    Friend WithEvents lblAnexoXml As Label
    Friend WithEvents lblAnexoPdf As Label
    Friend WithEvents lblAnexoBoleto As Label
    Friend WithEvents imgBoleto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
