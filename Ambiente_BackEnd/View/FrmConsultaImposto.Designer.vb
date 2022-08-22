<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaImposto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpesquisar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxFiltros = New System.Windows.Forms.ComboBox()
        Me.GRUPOCOFINSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dg_cofins = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GRUPOCOFINSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_cofins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 76)
        Me.Panel1.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(433, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 29)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "CONSULTAR IMPOSTOS"
        '
        'txtpesquisar
        '
        Me.txtpesquisar.Location = New System.Drawing.Point(83, 109)
        Me.txtpesquisar.Name = "txtpesquisar"
        Me.txtpesquisar.Size = New System.Drawing.Size(359, 20)
        Me.txtpesquisar.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Pesquisar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Filtros:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 571)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 64)
        Me.Panel2.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(474, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "F5 - FECHAR"
        '
        'cbxFiltros
        '
        Me.cbxFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxFiltros.FormattingEnabled = True
        Me.cbxFiltros.Items.AddRange(New Object() {"Codigo"})
        Me.cbxFiltros.Location = New System.Drawing.Point(10, 108)
        Me.cbxFiltros.Name = "cbxFiltros"
        Me.cbxFiltros.Size = New System.Drawing.Size(67, 21)
        Me.cbxFiltros.TabIndex = 87
        Me.cbxFiltros.Text = "Codigo"
        '
        'GRUPOCOFINSBindingSource
        '
        Me.GRUPOCOFINSBindingSource.DataMember = "GRUPO_COFINS"
        '
        'dg_cofins
        '
        Me.dg_cofins.AllowUserToAddRows = False
        Me.dg_cofins.AllowUserToDeleteRows = False
        Me.dg_cofins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_cofins.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_cofins.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_cofins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_cofins.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_cofins.ColumnHeadersHeight = 20
        Me.dg_cofins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_cofins.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg_cofins.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dg_cofins.Location = New System.Drawing.Point(0, 146)
        Me.dg_cofins.Name = "dg_cofins"
        Me.dg_cofins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_cofins.Size = New System.Drawing.Size(1076, 425)
        Me.dg_cofins.TabIndex = 93
        '
        'FrmConsultaImposto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 635)
        Me.Controls.Add(Me.dg_cofins)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpesquisar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbxFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmConsultaImposto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultaImposto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GRUPOCOFINSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_cofins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpesquisar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxFiltros As ComboBox
    Friend WithEvents GRUPOCOFINSBindingSource As BindingSource
    Friend WithEvents dg_cofins As DataGridView
End Class
