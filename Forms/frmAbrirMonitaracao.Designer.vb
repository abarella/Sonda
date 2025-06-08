<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirMonitaracao
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbPlano = New System.Windows.Forms.ComboBox
        Me.cmbVariacao = New System.Windows.Forms.ComboBox
        Me.cmbDetector = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdConfirmar = New System.Windows.Forms.Button
        Me.cmdLimpar = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me.cmbPortaSerial = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbNumeroContagem = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ABERTURA DE FICHA DE MONITORAÇÃO DE EMBALADOS RADIOATIVOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Detector"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPlano)
        Me.GroupBox1.Controls.Add(Me.cmbVariacao)
        Me.GroupBox1.Controls.Add(Me.cmbDetector)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 170)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da monitoração"
        '
        'cmbPlano
        '
        Me.cmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlano.FormattingEnabled = True
        Me.cmbPlano.Location = New System.Drawing.Point(181, 135)
        Me.cmbPlano.Name = "cmbPlano"
        Me.cmbPlano.Size = New System.Drawing.Size(458, 24)
        Me.cmbPlano.TabIndex = 6
        '
        'cmbVariacao
        '
        Me.cmbVariacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVariacao.FormattingEnabled = True
        Me.cmbVariacao.Location = New System.Drawing.Point(181, 86)
        Me.cmbVariacao.Name = "cmbVariacao"
        Me.cmbVariacao.Size = New System.Drawing.Size(458, 24)
        Me.cmbVariacao.TabIndex = 5
        '
        'cmbDetector
        '
        Me.cmbDetector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDetector.FormattingEnabled = True
        Me.cmbDetector.Location = New System.Drawing.Point(181, 36)
        Me.cmbDetector.Name = "cmbDetector"
        Me.cmbDetector.Size = New System.Drawing.Size(458, 24)
        Me.cmbDetector.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Plano"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Variação Percentual"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdConfirmar
        '
        Me.cmdConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmar.Location = New System.Drawing.Point(14, 340)
        Me.cmdConfirmar.Name = "cmdConfirmar"
        Me.cmdConfirmar.Size = New System.Drawing.Size(178, 54)
        Me.cmdConfirmar.TabIndex = 3
        Me.cmdConfirmar.Text = "&Confirmar"
        Me.cmdConfirmar.UseVisualStyleBackColor = True
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpar.Location = New System.Drawing.Point(249, 340)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(178, 54)
        Me.cmdLimpar.TabIndex = 4
        Me.cmdLimpar.Text = "&Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdSair
        '
        Me.cmdSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.Location = New System.Drawing.Point(483, 340)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(178, 54)
        Me.cmdSair.TabIndex = 5
        Me.cmdSair.Text = "&Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmbPortaSerial
        '
        Me.cmbPortaSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPortaSerial.FormattingEnabled = True
        Me.cmbPortaSerial.Location = New System.Drawing.Point(181, 32)
        Me.cmbPortaSerial.Name = "cmbPortaSerial"
        Me.cmbPortaSerial.Size = New System.Drawing.Size(115, 24)
        Me.cmbPortaSerial.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Porta Serial"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbNumeroContagem)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbPortaSerial)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(645, 76)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sonda"
        '
        'cmbNumeroContagem
        '
        Me.cmbNumeroContagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumeroContagem.FormattingEnabled = True
        Me.cmbNumeroContagem.Location = New System.Drawing.Point(509, 32)
        Me.cmbNumeroContagem.Name = "cmbNumeroContagem"
        Me.cmbNumeroContagem.Size = New System.Drawing.Size(115, 24)
        Me.cmbNumeroContagem.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(339, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nº Contagens(Seg.)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAbrirMonitaracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 407)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdConfirmar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAbrirMonitaracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABERTURA DE FICHA DE MONITORAÇÃO DE EMBALADOS RADIOATIVOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPlano As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVariacao As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDetector As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpar As System.Windows.Forms.Button
    Friend WithEvents cmdSair As System.Windows.Forms.Button
    Friend WithEvents cmbPortaSerial As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbNumeroContagem As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
