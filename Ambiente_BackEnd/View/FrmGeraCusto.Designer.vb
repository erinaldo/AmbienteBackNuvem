<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeraCusto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbxdesc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nTotal = New System.Windows.Forms.NumericUpDown()
        Me.percentual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgGeraCusto = New System.Windows.Forms.DataGridView()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrecoCompra = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPercentual = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGeraCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxdesc
        '
        Me.cbxdesc.FormattingEnabled = True
        Me.cbxdesc.Items.AddRange(New Object() {"CAMINHAO", "LUZ", "AGUA"})
        Me.cbxdesc.Location = New System.Drawing.Point(110, 101)
        Me.cbxdesc.Name = "cbxdesc"
        Me.cbxdesc.Size = New System.Drawing.Size(113, 21)
        Me.cbxdesc.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "F5 - Fechar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(426, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Total :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.nTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 42)
        Me.Panel2.TabIndex = 59
        '
        'nTotal
        '
        Me.nTotal.DecimalPlaces = 2
        Me.nTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.nTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nTotal.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nTotal.Location = New System.Drawing.Point(491, 0)
        Me.nTotal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nTotal.Name = "nTotal"
        Me.nTotal.Size = New System.Drawing.Size(84, 24)
        Me.nTotal.TabIndex = 46
        Me.nTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'percentual
        '
        Me.percentual.HeaderText = "Percentual (%)"
        Me.percentual.Name = "percentual"
        Me.percentual.ReadOnly = True
        '
        'descricao
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descricao.DefaultCellStyle = DataGridViewCellStyle1
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        '
        'dgGeraCusto
        '
        Me.dgGeraCusto.AllowUserToAddRows = False
        Me.dgGeraCusto.AllowUserToDeleteRows = False
        Me.dgGeraCusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgGeraCusto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgGeraCusto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGeraCusto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGeraCusto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGeraCusto.ColumnHeadersHeight = 20
        Me.dgGeraCusto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descricao, Me.percentual})
        Me.dgGeraCusto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGeraCusto.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgGeraCusto.Location = New System.Drawing.Point(6, 131)
        Me.dgGeraCusto.Name = "dgGeraCusto"
        Me.dgGeraCusto.ReadOnly = True
        Me.dgGeraCusto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGeraCusto.Size = New System.Drawing.Size(563, 165)
        Me.dgGeraCusto.TabIndex = 58
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(331, 102)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 57
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Percentual (%):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Descrição :"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(6, 102)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(100, 20)
        Me.txtDescricao.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gerar Custo"
        '
        'lblPrecoCompra
        '
        Me.lblPrecoCompra.AutoSize = True
        Me.lblPrecoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoCompra.ForeColor = System.Drawing.Color.White
        Me.lblPrecoCompra.Location = New System.Drawing.Point(107, 49)
        Me.lblPrecoCompra.Name = "lblPrecoCompra"
        Me.lblPrecoCompra.Size = New System.Drawing.Size(13, 16)
        Me.lblPrecoCompra.TabIndex = 3
        Me.lblPrecoCompra.Text = ".."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Preço Compra:"
        '
        'txtPercentual
        '
        Me.txtPercentual.Location = New System.Drawing.Point(225, 102)
        Me.txtPercentual.Name = "txtPercentual"
        Me.txtPercentual.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentual.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblPrecoCompra)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 71)
        Me.Panel1.TabIndex = 53
        '
        'FrmGeraCusto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 344)
        Me.Controls.Add(Me.cbxdesc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgGeraCusto)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtPercentual)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "FrmGeraCusto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar Custo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGeraCusto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxdesc As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Public WithEvents nTotal As NumericUpDown
    Friend WithEvents percentual As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents dgGeraCusto As DataGridView
    Friend WithEvents btnInserir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrecoCompra As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPercentual As TextBox
    Friend WithEvents Panel1 As Panel
End Class
