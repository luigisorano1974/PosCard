<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGridCard
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCards = New System.Windows.Forms.ListView()
        Me.ColumnCodice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comboFiliale = New System.Windows.Forms.ComboBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblFiliale = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupEdit = New System.Windows.Forms.GroupBox()
        Me.GroupEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCards
        '
        Me.lstCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCards.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCodice, Me.ColumnSaldo})
        Me.lstCards.Enabled = False
        Me.lstCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCards.FullRowSelect = True
        Me.lstCards.GridLines = True
        Me.lstCards.HideSelection = False
        Me.lstCards.Location = New System.Drawing.Point(12, 77)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(536, 195)
        Me.lstCards.TabIndex = 0
        Me.lstCards.UseCompatibleStateImageBehavior = False
        Me.lstCards.View = System.Windows.Forms.View.Details
        '
        'ColumnCodice
        '
        Me.ColumnCodice.Text = "Codice Card"
        Me.ColumnCodice.Width = 292
        '
        'ColumnSaldo
        '
        Me.ColumnSaldo.Text = "Saldo"
        Me.ColumnSaldo.Width = 209
        '
        'comboFiliale
        '
        Me.comboFiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFiliale.FormattingEnabled = True
        Me.comboFiliale.Location = New System.Drawing.Point(146, 18)
        Me.comboFiliale.Name = "comboFiliale"
        Me.comboFiliale.Size = New System.Drawing.Size(121, 28)
        Me.comboFiliale.TabIndex = 1
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(287, 34)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 26)
        Me.txtSaldo.TabIndex = 2
        '
        'lblFiliale
        '
        Me.lblFiliale.AutoSize = True
        Me.lblFiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiliale.Location = New System.Drawing.Point(130, 37)
        Me.lblFiliale.Name = "lblFiliale"
        Me.lblFiliale.Size = New System.Drawing.Size(57, 20)
        Me.lblFiliale.TabIndex = 3
        Me.lblFiliale.Text = "Label1"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(419, 34)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 26)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Modifica"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codice Card: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Codice Filiale"
        '
        'GroupEdit
        '
        Me.GroupEdit.Controls.Add(Me.Label1)
        Me.GroupEdit.Controls.Add(Me.txtSaldo)
        Me.GroupEdit.Controls.Add(Me.Label2)
        Me.GroupEdit.Controls.Add(Me.lblFiliale)
        Me.GroupEdit.Controls.Add(Me.btnEdit)
        Me.GroupEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupEdit.Location = New System.Drawing.Point(12, 298)
        Me.GroupEdit.Name = "GroupEdit"
        Me.GroupEdit.Size = New System.Drawing.Size(536, 84)
        Me.GroupEdit.TabIndex = 8
        Me.GroupEdit.TabStop = False
        Me.GroupEdit.Text = "Dettaglio Card"
        Me.GroupEdit.Visible = False
        '
        'formGridCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 398)
        Me.Controls.Add(Me.GroupEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboFiliale)
        Me.Controls.Add(Me.lstCards)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formGridCard"
        Me.Text = "Grid Card"
        Me.GroupEdit.ResumeLayout(False)
        Me.GroupEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents columnHeader6 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Private WithEvents columnHeader1 As ColumnHeader
    Friend WithEvents lstCards As ListView
    Friend WithEvents ColumnCodice As ColumnHeader
    Friend WithEvents ColumnSaldo As ColumnHeader
    Friend WithEvents comboFiliale As ComboBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lblFiliale As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupEdit As GroupBox
End Class
