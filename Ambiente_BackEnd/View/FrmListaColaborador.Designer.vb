<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListaColaborador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaColaborador))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DsAmbiente = New Ambiente_BackEnd.dsAmbiente()
        Me.COLABORADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.CODCOLABORADORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZAOSOCIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEFANTASIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLABORADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 52)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "F5 - Fechar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 57)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(251, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultar Colaborador"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(620, 20)
        Me.TextBox1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Descrição :"
        '
        'DsAmbiente
        '
        Me.DsAmbiente.DataSetName = "dsAmbiente"
        Me.DsAmbiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLABORADORBindingSource
        '
        Me.COLABORADORBindingSource.DataMember = "COLABORADOR"
        Me.COLABORADORBindingSource.DataSource = Me.DsAmbiente
        '
        'dgConsultaCliente
        '
        Me.dgConsultaCliente.AllowUserToAddRows = False
        Me.dgConsultaCliente.AllowUserToDeleteRows = False
        Me.dgConsultaCliente.AutoGenerateColumns = False
        Me.dgConsultaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgConsultaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgConsultaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConsultaCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsultaCliente.ColumnHeadersHeight = 20
        Me.dgConsultaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODCOLABORADORDataGridViewTextBoxColumn, Me.RAZAOSOCIALDataGridViewTextBoxColumn, Me.NOMEFANTASIA})
        Me.dgConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgConsultaCliente.DataSource = Me.COLABORADORBindingSource
        Me.dgConsultaCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgConsultaCliente.GridColor = System.Drawing.SystemColors.HighlightText
        Me.dgConsultaCliente.Location = New System.Drawing.Point(0, 107)
        Me.dgConsultaCliente.Name = "dgConsultaCliente"
        Me.dgConsultaCliente.ReadOnly = True
        Me.dgConsultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaCliente.Size = New System.Drawing.Size(763, 299)
        Me.dgConsultaCliente.TabIndex = 52
        '
        'CODCOLABORADORDataGridViewTextBoxColumn
        '
        Me.CODCOLABORADORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CODCOLABORADORDataGridViewTextBoxColumn.DataPropertyName = "CODCOLABORADOR"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.Name = "CODCOLABORADORDataGridViewTextBoxColumn"
        Me.CODCOLABORADORDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODCOLABORADORDataGridViewTextBoxColumn.Width = 70
        '
        'RAZAOSOCIALDataGridViewTextBoxColumn
        '
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAOSOCIAL"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "NOME"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.Name = "RAZAOSOCIALDataGridViewTextBoxColumn"
        Me.RAZAOSOCIALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMEFANTASIA
        '
        Me.NOMEFANTASIA.DataPropertyName = "NOMEFANTASIA"
        Me.NOMEFANTASIA.HeaderText = "FANTASIA"
        Me.NOMEFANTASIA.Name = "NOMEFANTASIA"
        Me.NOMEFANTASIA.ReadOnly = True
        '
        'btnNovo
        '
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(6, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 45)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'FrmListaColaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 458)
        Me.Controls.Add(Me.dgConsultaCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmListaColaborador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Colaborador"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DsAmbiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLABORADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DsAmbiente As dsAmbiente
    Friend WithEvents COLABORADORBindingSource As BindingSource
    Friend WithEvents dgConsultaCliente As DataGridView
    Friend WithEvents CODCOLABORADORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RAZAOSOCIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEFANTASIA As DataGridViewTextBoxColumn
    Friend WithEvents btnNovo As Button
End Class
