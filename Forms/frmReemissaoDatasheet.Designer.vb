<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReemissaoDatasheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grbDose = New System.Windows.Forms.GroupBox
        Me.txtLote = New System.Windows.Forms.TextBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.btnZerar = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.grbDose.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpar)
        Me.GroupBox3.Controls.Add(Me.btnSair)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(771, 88)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Navy
        Me.btnLimpar.Location = New System.Drawing.Point(38, 30)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(217, 32)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Navy
        Me.btnSair.Location = New System.Drawing.Point(501, 30)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(217, 32)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'grbDose
        '
        Me.grbDose.Controls.Add(Me.txtLote)
        Me.grbDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDose.ForeColor = System.Drawing.Color.Black
        Me.grbDose.Location = New System.Drawing.Point(12, 29)
        Me.grbDose.Name = "grbDose"
        Me.grbDose.Size = New System.Drawing.Size(361, 144)
        Me.grbDose.TabIndex = 58
        Me.grbDose.TabStop = False
        Me.grbDose.Text = "Lote/Número"
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.ForeColor = System.Drawing.Color.Navy
        Me.txtLote.Location = New System.Drawing.Point(7, 40)
        Me.txtLote.MaxLength = 9
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(348, 92)
        Me.txtLote.TabIndex = 0
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Navy
        Me.btnConfirmar.Location = New System.Drawing.Point(513, 69)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(217, 92)
        Me.btnConfirmar.TabIndex = 57
        Me.btnConfirmar.Text = "Imprimir"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnZerar
        '
        Me.btnZerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnZerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZerar.ForeColor = System.Drawing.Color.Navy
        Me.btnZerar.Location = New System.Drawing.Point(12, 288)
        Me.btnZerar.Name = "btnZerar"
        Me.btnZerar.Size = New System.Drawing.Size(760, 92)
        Me.btnZerar.TabIndex = 71
        Me.btnZerar.Text = "Zerar balde para passar novamente na esteira"
        Me.btnZerar.UseVisualStyleBackColor = False
        '
        'frmReemissaoDatasheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 402)
        Me.Controls.Add(Me.btnZerar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grbDose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmReemissaoDatasheet"
        Me.Text = "Imprimir DataSheet"
        Me.GroupBox3.ResumeLayout(False)
        Me.grbDose.ResumeLayout(False)
        Me.grbDose.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Public WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grbDose As System.Windows.Forms.GroupBox
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnZerar As System.Windows.Forms.Button
End Class
