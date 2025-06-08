<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMonitorarEmbalados
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ReadElecMeas As System.Windows.Forms.Button
    Public WithEvents Discri As System.Windows.Forms.Label
    Public WithEvents HV As System.Windows.Forms.Label
    Public WithEvents Alim As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents MeasFrame As System.Windows.Forms.GroupBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Count2 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Count1 As System.Windows.Forms.Label
    Public WithEvents CountFrame As System.Windows.Forms.GroupBox
    Public WithEvents Fichier As System.Windows.Forms.TextBox
    Public WithEvents Modif As System.Windows.Forms.Button
    Public WithEvents Save As System.Windows.Forms.Button
    Public WithEvents List1 As System.Windows.Forms.ListBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents lblComunicacaoSonda As System.Windows.Forms.Label
    Public WithEvents UnitSet As System.Windows.Forms.Button
    Public WithEvents SI As System.Windows.Forms.RadioButton
    Public WithEvents US As System.Windows.Forms.RadioButton
    Public WithEvents UnitSys As System.Windows.Forms.GroupBox
    Public WithEvents Index As System.Windows.Forms.Button
    Public WithEvents Alrm_Lvl As System.Windows.Forms.ComboBox
    Public WithEvents Unit As System.Windows.Forms.ComboBox
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents ReadCritParam As System.Windows.Forms.Button
    Public WithEvents TimeCalib1 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Date1 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Emitter1 As System.Windows.Forms.Label
    Public WithEvents Emit1 As System.Windows.Forms.Label
    Public WithEvents RefSource As System.Windows.Forms.Label
    Public WithEvents Source1 As System.Windows.Forms.Label
    Public WithEvents TimeCalib2 As System.Windows.Forms.Label
    Public WithEvents Time2 As System.Windows.Forms.Label
    Public WithEvents Date2 As System.Windows.Forms.Label
    Public WithEvents DateTitle As System.Windows.Forms.Label
    Public WithEvents Emitter2 As System.Windows.Forms.Label
    Public WithEvents Emit2 As System.Windows.Forms.Label
    Public WithEvents RefSource2 As System.Windows.Forms.Label
    Public WithEvents Source2 As System.Windows.Forms.Label
    Public WithEvents CritFrame As System.Windows.Forms.GroupBox
    Public WithEvents Mode As System.Windows.Forms.Label
    Public WithEvents CSPName As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MeasFrame = New System.Windows.Forms.GroupBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.Fichier = New System.Windows.Forms.TextBox()
        Me.Modif = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.ReadElecMeas = New System.Windows.Forms.Button()
        Me.Discri = New System.Windows.Forms.Label()
        Me.HV = New System.Windows.Forms.Label()
        Me.Alim = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CountFrame = New System.Windows.Forms.GroupBox()
        Me.Count2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Count1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblComunicacaoSonda = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CritFrame = New System.Windows.Forms.GroupBox()
        Me.ReadCritParam = New System.Windows.Forms.Button()
        Me.TimeCalib1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Date1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Emitter1 = New System.Windows.Forms.Label()
        Me.Emit1 = New System.Windows.Forms.Label()
        Me.RefSource = New System.Windows.Forms.Label()
        Me.Source1 = New System.Windows.Forms.Label()
        Me.TimeCalib2 = New System.Windows.Forms.Label()
        Me.Time2 = New System.Windows.Forms.Label()
        Me.Date2 = New System.Windows.Forms.Label()
        Me.DateTitle = New System.Windows.Forms.Label()
        Me.Emitter2 = New System.Windows.Forms.Label()
        Me.Emit2 = New System.Windows.Forms.Label()
        Me.RefSource2 = New System.Windows.Forms.Label()
        Me.Source2 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.UnitSet = New System.Windows.Forms.Button()
        Me.UnitSys = New System.Windows.Forms.GroupBox()
        Me.SI = New System.Windows.Forms.RadioButton()
        Me.US = New System.Windows.Forms.RadioButton()
        Me.Index = New System.Windows.Forms.Button()
        Me.Alrm_Lvl = New System.Windows.Forms.ComboBox()
        Me.Unit = New System.Windows.Forms.ComboBox()
        Me.Mode = New System.Windows.Forms.Label()
        Me.CSPName = New System.Windows.Forms.Label()
        Me.lblQtdMedidas = New System.Windows.Forms.Label()
        Me.lblMaiorValor1 = New System.Windows.Forms.Label()
        Me.lblValorMedio = New System.Windows.Forms.Label()
        Me.lstValores = New System.Windows.Forms.ListBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSuperficie = New System.Windows.Forms.TextBox()
        Me.txtMetro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnFecharMensagem = New System.Windows.Forms.Button()
        Me.lblDose = New System.Windows.Forms.Label()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblAtividade = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.grbDose = New System.Windows.Forms.GroupBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUltimoLote = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Sonda = New System.Windows.Forms.GroupBox()
        Me.btnResetSonda = New System.Windows.Forms.Button()
        Me.lblMaiorValor3 = New System.Windows.Forms.Label()
        Me.lblMaiorValor2 = New System.Windows.Forms.Label()
        Me.MeasFrame.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.CountFrame.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.CritFrame.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.UnitSys.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grbDose.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Sonda.SuspendLayout()
        Me.SuspendLayout()
        '
        'MeasFrame
        '
        Me.MeasFrame.BackColor = System.Drawing.SystemColors.Control
        Me.MeasFrame.Controls.Add(Me.Frame7)
        Me.MeasFrame.Controls.Add(Me.ReadElecMeas)
        Me.MeasFrame.Controls.Add(Me.Discri)
        Me.MeasFrame.Controls.Add(Me.HV)
        Me.MeasFrame.Controls.Add(Me.Alim)
        Me.MeasFrame.Controls.Add(Me.Label15)
        Me.MeasFrame.Controls.Add(Me.Label3)
        Me.MeasFrame.Controls.Add(Me.Label1)
        Me.MeasFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MeasFrame.Location = New System.Drawing.Point(55, 188)
        Me.MeasFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.MeasFrame.Name = "MeasFrame"
        Me.MeasFrame.Padding = New System.Windows.Forms.Padding(0)
        Me.MeasFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MeasFrame.Size = New System.Drawing.Size(289, 297)
        Me.MeasFrame.TabIndex = 23
        Me.MeasFrame.TabStop = False
        Me.MeasFrame.Text = "Electronic Measures"
        Me.MeasFrame.Visible = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.Fichier)
        Me.Frame7.Controls.Add(Me.Modif)
        Me.Frame7.Controls.Add(Me.Save)
        Me.Frame7.Controls.Add(Me.List1)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(77, 15)
        Me.Frame7.Margin = New System.Windows.Forms.Padding(4)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(769, 60)
        Me.Frame7.TabIndex = 9
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Save"
        Me.Frame7.Visible = False
        '
        'Fichier
        '
        Me.Fichier.AcceptsReturn = True
        Me.Fichier.BackColor = System.Drawing.SystemColors.Window
        Me.Fichier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fichier.Enabled = False
        Me.Fichier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Fichier.Location = New System.Drawing.Point(277, 20)
        Me.Fichier.Margin = New System.Windows.Forms.Padding(4)
        Me.Fichier.MaxLength = 0
        Me.Fichier.Name = "Fichier"
        Me.Fichier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fichier.Size = New System.Drawing.Size(192, 22)
        Me.Fichier.TabIndex = 44
        Me.Fichier.TabStop = False
        '
        'Modif
        '
        Me.Modif.BackColor = System.Drawing.SystemColors.Control
        Me.Modif.Cursor = System.Windows.Forms.Cursors.Default
        Me.Modif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Modif.Location = New System.Drawing.Point(533, 20)
        Me.Modif.Margin = New System.Windows.Forms.Padding(4)
        Me.Modif.Name = "Modif"
        Me.Modif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Modif.Size = New System.Drawing.Size(97, 31)
        Me.Modif.TabIndex = 40
        Me.Modif.Text = "Modify"
        Me.Modif.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.SystemColors.Control
        Me.Save.Cursor = System.Windows.Forms.Cursors.Default
        Me.Save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Save.Location = New System.Drawing.Point(661, 20)
        Me.Save.Margin = New System.Windows.Forms.Padding(4)
        Me.Save.Name = "Save"
        Me.Save.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Save.Size = New System.Drawing.Size(97, 31)
        Me.Save.TabIndex = 11
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 16
        Me.List1.Items.AddRange(New Object() {"None", "Errors", "Req", "Counts", "All"})
        Me.List1.Location = New System.Drawing.Point(75, 20)
        Me.List1.Margin = New System.Windows.Forms.Padding(4)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(139, 20)
        Me.List1.TabIndex = 10
        '
        'ReadElecMeas
        '
        Me.ReadElecMeas.BackColor = System.Drawing.SystemColors.Control
        Me.ReadElecMeas.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReadElecMeas.Enabled = False
        Me.ReadElecMeas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReadElecMeas.Location = New System.Drawing.Point(43, 246)
        Me.ReadElecMeas.Margin = New System.Windows.Forms.Padding(4)
        Me.ReadElecMeas.Name = "ReadElecMeas"
        Me.ReadElecMeas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReadElecMeas.Size = New System.Drawing.Size(97, 31)
        Me.ReadElecMeas.TabIndex = 35
        Me.ReadElecMeas.Text = "Read"
        Me.ReadElecMeas.UseVisualStyleBackColor = False
        '
        'Discri
        '
        Me.Discri.BackColor = System.Drawing.SystemColors.Window
        Me.Discri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Discri.Cursor = System.Windows.Forms.Cursors.Default
        Me.Discri.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Discri.Location = New System.Drawing.Point(160, 197)
        Me.Discri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Discri.Name = "Discri"
        Me.Discri.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Discri.Size = New System.Drawing.Size(97, 20)
        Me.Discri.TabIndex = 34
        Me.Discri.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HV
        '
        Me.HV.BackColor = System.Drawing.SystemColors.Window
        Me.HV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HV.Cursor = System.Windows.Forms.Cursors.Default
        Me.HV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HV.Location = New System.Drawing.Point(160, 128)
        Me.HV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HV.Name = "HV"
        Me.HV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HV.Size = New System.Drawing.Size(97, 20)
        Me.HV.TabIndex = 33
        Me.HV.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Alim
        '
        Me.Alim.BackColor = System.Drawing.SystemColors.Window
        Me.Alim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alim.Cursor = System.Windows.Forms.Cursors.Default
        Me.Alim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Alim.Location = New System.Drawing.Point(160, 59)
        Me.Alim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Alim.Name = "Alim"
        Me.Alim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Alim.Size = New System.Drawing.Size(97, 20)
        Me.Alim.TabIndex = 32
        Me.Alim.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(43, 187)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(97, 41)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Discrimination Level"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "HV"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 41)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tension d'Alimentation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CountFrame
        '
        Me.CountFrame.BackColor = System.Drawing.SystemColors.Control
        Me.CountFrame.Controls.Add(Me.Count2)
        Me.CountFrame.Controls.Add(Me.Label14)
        Me.CountFrame.Controls.Add(Me.Count1)
        Me.CountFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CountFrame.Location = New System.Drawing.Point(11, 242)
        Me.CountFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.CountFrame.Name = "CountFrame"
        Me.CountFrame.Padding = New System.Windows.Forms.Padding(0)
        Me.CountFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CountFrame.Size = New System.Drawing.Size(364, 134)
        Me.CountFrame.TabIndex = 22
        Me.CountFrame.TabStop = False
        Me.CountFrame.Text = "Count"
        Me.CountFrame.Visible = False
        '
        'Count2
        '
        Me.Count2.BackColor = System.Drawing.SystemColors.Window
        Me.Count2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Count2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Count2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Count2.Location = New System.Drawing.Point(160, 89)
        Me.Count2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Count2.Name = "Count2"
        Me.Count2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Count2.Size = New System.Drawing.Size(97, 20)
        Me.Count2.TabIndex = 28
        Me.Count2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(96, 89)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(97, 21)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Count 2"
        '
        'Count1
        '
        Me.Count1.BackColor = System.Drawing.SystemColors.Window
        Me.Count1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Count1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Count1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Count1.Location = New System.Drawing.Point(160, 30)
        Me.Count1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Count1.Name = "Count1"
        Me.Count1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Count1.Size = New System.Drawing.Size(97, 20)
        Me.Count1.TabIndex = 26
        Me.Count1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'lblComunicacaoSonda
        '
        Me.lblComunicacaoSonda.BackColor = System.Drawing.SystemColors.Control
        Me.lblComunicacaoSonda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComunicacaoSonda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComunicacaoSonda.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblComunicacaoSonda.Location = New System.Drawing.Point(7, 30)
        Me.lblComunicacaoSonda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComunicacaoSonda.Name = "lblComunicacaoSonda"
        Me.lblComunicacaoSonda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComunicacaoSonda.Size = New System.Drawing.Size(297, 66)
        Me.lblComunicacaoSonda.TabIndex = 8
        Me.lblComunicacaoSonda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.CritFrame)
        Me.Frame2.Controls.Add(Me.CountFrame)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(5, 79)
        Me.Frame2.Margin = New System.Windows.Forms.Padding(4)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(440, 448)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Parameters"
        Me.Frame2.Visible = False
        '
        'CritFrame
        '
        Me.CritFrame.BackColor = System.Drawing.SystemColors.Control
        Me.CritFrame.Controls.Add(Me.ReadCritParam)
        Me.CritFrame.Controls.Add(Me.TimeCalib1)
        Me.CritFrame.Controls.Add(Me.Label10)
        Me.CritFrame.Controls.Add(Me.Date1)
        Me.CritFrame.Controls.Add(Me.Label9)
        Me.CritFrame.Controls.Add(Me.Emitter1)
        Me.CritFrame.Controls.Add(Me.Emit1)
        Me.CritFrame.Controls.Add(Me.MeasFrame)
        Me.CritFrame.Controls.Add(Me.RefSource)
        Me.CritFrame.Controls.Add(Me.Source1)
        Me.CritFrame.Controls.Add(Me.TimeCalib2)
        Me.CritFrame.Controls.Add(Me.Time2)
        Me.CritFrame.Controls.Add(Me.Date2)
        Me.CritFrame.Controls.Add(Me.DateTitle)
        Me.CritFrame.Controls.Add(Me.Emitter2)
        Me.CritFrame.Controls.Add(Me.Emit2)
        Me.CritFrame.Controls.Add(Me.RefSource2)
        Me.CritFrame.Controls.Add(Me.Source2)
        Me.CritFrame.Controls.Add(Me.Frame3)
        Me.CritFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CritFrame.Location = New System.Drawing.Point(11, 393)
        Me.CritFrame.Margin = New System.Windows.Forms.Padding(4)
        Me.CritFrame.Name = "CritFrame"
        Me.CritFrame.Padding = New System.Windows.Forms.Padding(0)
        Me.CritFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CritFrame.Size = New System.Drawing.Size(417, 494)
        Me.CritFrame.TabIndex = 6
        Me.CritFrame.TabStop = False
        Me.CritFrame.Text = "Critical Parameters"
        Me.CritFrame.Visible = False
        '
        'ReadCritParam
        '
        Me.ReadCritParam.BackColor = System.Drawing.SystemColors.Control
        Me.ReadCritParam.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReadCritParam.Enabled = False
        Me.ReadCritParam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReadCritParam.Location = New System.Drawing.Point(296, 188)
        Me.ReadCritParam.Margin = New System.Windows.Forms.Padding(4)
        Me.ReadCritParam.Name = "ReadCritParam"
        Me.ReadCritParam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReadCritParam.Size = New System.Drawing.Size(97, 31)
        Me.ReadCritParam.TabIndex = 36
        Me.ReadCritParam.Text = "Read"
        Me.ReadCritParam.UseVisualStyleBackColor = False
        '
        'TimeCalib1
        '
        Me.TimeCalib1.BackColor = System.Drawing.SystemColors.Control
        Me.TimeCalib1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeCalib1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TimeCalib1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TimeCalib1.Location = New System.Drawing.Point(136, 156)
        Me.TimeCalib1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeCalib1.Name = "TimeCalib1"
        Me.TimeCalib1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeCalib1.Size = New System.Drawing.Size(87, 21)
        Me.TimeCalib1.TabIndex = 64
        Me.TimeCalib1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(61, 156)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 21)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Time 1 :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Date1
        '
        Me.Date1.BackColor = System.Drawing.SystemColors.Control
        Me.Date1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Date1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Date1.Location = New System.Drawing.Point(136, 117)
        Me.Date1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Date1.Name = "Date1"
        Me.Date1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Date1.Size = New System.Drawing.Size(87, 21)
        Me.Date1.TabIndex = 62
        Me.Date1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(51, 117)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(76, 21)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Date 1 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Emitter1
        '
        Me.Emitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Emitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emitter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Emitter1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Emitter1.Location = New System.Drawing.Point(136, 78)
        Me.Emitter1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Emitter1.Name = "Emitter1"
        Me.Emitter1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Emitter1.Size = New System.Drawing.Size(87, 21)
        Me.Emitter1.TabIndex = 60
        Me.Emitter1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Emit1
        '
        Me.Emit1.BackColor = System.Drawing.SystemColors.Control
        Me.Emit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Emit1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Emit1.Location = New System.Drawing.Point(40, 78)
        Me.Emit1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Emit1.Name = "Emit1"
        Me.Emit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Emit1.Size = New System.Drawing.Size(87, 21)
        Me.Emit1.TabIndex = 59
        Me.Emit1.Text = "Emitter 1 :"
        Me.Emit1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RefSource
        '
        Me.RefSource.BackColor = System.Drawing.SystemColors.Control
        Me.RefSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RefSource.Cursor = System.Windows.Forms.Cursors.Default
        Me.RefSource.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefSource.Location = New System.Drawing.Point(136, 38)
        Me.RefSource.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RefSource.Name = "RefSource"
        Me.RefSource.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RefSource.Size = New System.Drawing.Size(87, 21)
        Me.RefSource.TabIndex = 58
        Me.RefSource.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Source1
        '
        Me.Source1.BackColor = System.Drawing.SystemColors.Control
        Me.Source1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Source1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Source1.Location = New System.Drawing.Point(29, 38)
        Me.Source1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Source1.Name = "Source1"
        Me.Source1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Source1.Size = New System.Drawing.Size(97, 21)
        Me.Source1.TabIndex = 57
        Me.Source1.Text = "Source 1 :"
        Me.Source1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TimeCalib2
        '
        Me.TimeCalib2.BackColor = System.Drawing.SystemColors.Control
        Me.TimeCalib2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeCalib2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TimeCalib2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TimeCalib2.Location = New System.Drawing.Point(307, 156)
        Me.TimeCalib2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeCalib2.Name = "TimeCalib2"
        Me.TimeCalib2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeCalib2.Size = New System.Drawing.Size(87, 21)
        Me.TimeCalib2.TabIndex = 56
        Me.TimeCalib2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Time2
        '
        Me.Time2.BackColor = System.Drawing.SystemColors.Control
        Me.Time2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Time2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Time2.Location = New System.Drawing.Point(232, 156)
        Me.Time2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time2.Name = "Time2"
        Me.Time2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Time2.Size = New System.Drawing.Size(65, 21)
        Me.Time2.TabIndex = 55
        Me.Time2.Text = "Time 2 :"
        Me.Time2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Date2
        '
        Me.Date2.BackColor = System.Drawing.SystemColors.Control
        Me.Date2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Date2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Date2.Location = New System.Drawing.Point(307, 117)
        Me.Date2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Date2.Name = "Date2"
        Me.Date2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Date2.Size = New System.Drawing.Size(87, 21)
        Me.Date2.TabIndex = 54
        Me.Date2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateTitle
        '
        Me.DateTitle.BackColor = System.Drawing.SystemColors.Control
        Me.DateTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DateTitle.Location = New System.Drawing.Point(221, 117)
        Me.DateTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateTitle.Name = "DateTitle"
        Me.DateTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTitle.Size = New System.Drawing.Size(76, 21)
        Me.DateTitle.TabIndex = 53
        Me.DateTitle.Text = "Date 2 :"
        Me.DateTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Emitter2
        '
        Me.Emitter2.BackColor = System.Drawing.SystemColors.Control
        Me.Emitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emitter2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Emitter2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Emitter2.Location = New System.Drawing.Point(307, 78)
        Me.Emitter2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Emitter2.Name = "Emitter2"
        Me.Emitter2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Emitter2.Size = New System.Drawing.Size(87, 21)
        Me.Emitter2.TabIndex = 52
        Me.Emitter2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Emit2
        '
        Me.Emit2.BackColor = System.Drawing.SystemColors.Control
        Me.Emit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Emit2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Emit2.Location = New System.Drawing.Point(211, 78)
        Me.Emit2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Emit2.Name = "Emit2"
        Me.Emit2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Emit2.Size = New System.Drawing.Size(87, 21)
        Me.Emit2.TabIndex = 51
        Me.Emit2.Text = "Emitter 2 :"
        Me.Emit2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RefSource2
        '
        Me.RefSource2.BackColor = System.Drawing.SystemColors.Control
        Me.RefSource2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RefSource2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RefSource2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefSource2.Location = New System.Drawing.Point(307, 38)
        Me.RefSource2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RefSource2.Name = "RefSource2"
        Me.RefSource2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RefSource2.Size = New System.Drawing.Size(87, 21)
        Me.RefSource2.TabIndex = 50
        Me.RefSource2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Source2
        '
        Me.Source2.BackColor = System.Drawing.SystemColors.Control
        Me.Source2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Source2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Source2.Location = New System.Drawing.Point(200, 38)
        Me.Source2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Source2.Name = "Source2"
        Me.Source2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Source2.Size = New System.Drawing.Size(97, 21)
        Me.Source2.TabIndex = 49
        Me.Source2.Text = "Source 2 :"
        Me.Source2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.UnitSet)
        Me.Frame3.Controls.Add(Me.UnitSys)
        Me.Frame3.Controls.Add(Me.Index)
        Me.Frame3.Controls.Add(Me.Alrm_Lvl)
        Me.Frame3.Controls.Add(Me.Unit)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(15, 256)
        Me.Frame3.Margin = New System.Windows.Forms.Padding(4)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(695, 119)
        Me.Frame3.TabIndex = 3
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Alarm Levels"
        Me.Frame3.Visible = False
        '
        'UnitSet
        '
        Me.UnitSet.BackColor = System.Drawing.SystemColors.Control
        Me.UnitSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.UnitSet.Enabled = False
        Me.UnitSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UnitSet.Location = New System.Drawing.Point(352, 39)
        Me.UnitSet.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitSet.Name = "UnitSet"
        Me.UnitSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UnitSet.Size = New System.Drawing.Size(119, 41)
        Me.UnitSet.TabIndex = 41
        Me.UnitSet.Text = "SetUnit"
        Me.UnitSet.UseVisualStyleBackColor = False
        '
        'UnitSys
        '
        Me.UnitSys.BackColor = System.Drawing.SystemColors.Control
        Me.UnitSys.Controls.Add(Me.SI)
        Me.UnitSys.Controls.Add(Me.US)
        Me.UnitSys.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UnitSys.Location = New System.Drawing.Point(32, 20)
        Me.UnitSys.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitSys.Name = "UnitSys"
        Me.UnitSys.Padding = New System.Windows.Forms.Padding(0)
        Me.UnitSys.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UnitSys.Size = New System.Drawing.Size(268, 50)
        Me.UnitSys.TabIndex = 12
        Me.UnitSys.TabStop = False
        Me.UnitSys.Text = "Unit System"
        '
        'SI
        '
        Me.SI.BackColor = System.Drawing.SystemColors.Control
        Me.SI.Cursor = System.Windows.Forms.Cursors.Default
        Me.SI.Enabled = False
        Me.SI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SI.Location = New System.Drawing.Point(53, 20)
        Me.SI.Margin = New System.Windows.Forms.Padding(4)
        Me.SI.Name = "SI"
        Me.SI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SI.Size = New System.Drawing.Size(44, 21)
        Me.SI.TabIndex = 14
        Me.SI.TabStop = True
        Me.SI.Text = "SI"
        Me.SI.UseVisualStyleBackColor = False
        '
        'US
        '
        Me.US.BackColor = System.Drawing.SystemColors.Control
        Me.US.Cursor = System.Windows.Forms.Cursors.Default
        Me.US.Enabled = False
        Me.US.ForeColor = System.Drawing.SystemColors.ControlText
        Me.US.Location = New System.Drawing.Point(149, 20)
        Me.US.Margin = New System.Windows.Forms.Padding(4)
        Me.US.Name = "US"
        Me.US.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.US.Size = New System.Drawing.Size(65, 21)
        Me.US.TabIndex = 13
        Me.US.TabStop = True
        Me.US.Text = "US"
        Me.US.UseVisualStyleBackColor = False
        '
        'Index
        '
        Me.Index.BackColor = System.Drawing.SystemColors.Control
        Me.Index.Cursor = System.Windows.Forms.Cursors.Default
        Me.Index.Enabled = False
        Me.Index.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Index.Location = New System.Drawing.Point(512, 39)
        Me.Index.Margin = New System.Windows.Forms.Padding(4)
        Me.Index.Name = "Index"
        Me.Index.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Index.Size = New System.Drawing.Size(119, 41)
        Me.Index.TabIndex = 7
        Me.Index.Text = "New Index"
        Me.Index.UseVisualStyleBackColor = False
        '
        'Alrm_Lvl
        '
        Me.Alrm_Lvl.BackColor = System.Drawing.SystemColors.Window
        Me.Alrm_Lvl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Alrm_Lvl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Alrm_Lvl.Location = New System.Drawing.Point(181, 79)
        Me.Alrm_Lvl.Margin = New System.Windows.Forms.Padding(4)
        Me.Alrm_Lvl.Name = "Alrm_Lvl"
        Me.Alrm_Lvl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Alrm_Lvl.Size = New System.Drawing.Size(107, 24)
        Me.Alrm_Lvl.TabIndex = 5
        Me.Alrm_Lvl.Text = "Alarm Levels"
        '
        'Unit
        '
        Me.Unit.BackColor = System.Drawing.SystemColors.Window
        Me.Unit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Unit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Unit.Items.AddRange(New Object() {"c/s"})
        Me.Unit.Location = New System.Drawing.Point(53, 79)
        Me.Unit.Margin = New System.Windows.Forms.Padding(4)
        Me.Unit.Name = "Unit"
        Me.Unit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Unit.Size = New System.Drawing.Size(107, 24)
        Me.Unit.TabIndex = 4
        '
        'Mode
        '
        Me.Mode.BackColor = System.Drawing.SystemColors.Control
        Me.Mode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Mode.Cursor = System.Windows.Forms.Cursors.Default
        Me.Mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mode.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Mode.Location = New System.Drawing.Point(8, 66)
        Me.Mode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Mode.Name = "Mode"
        Me.Mode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mode.Size = New System.Drawing.Size(299, 31)
        Me.Mode.TabIndex = 39
        Me.Mode.Text = "Modo de Acesso"
        Me.Mode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Mode.Visible = False
        '
        'CSPName
        '
        Me.CSPName.BackColor = System.Drawing.SystemColors.Control
        Me.CSPName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CSPName.Cursor = System.Windows.Forms.Cursors.Default
        Me.CSPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSPName.ForeColor = System.Drawing.Color.DimGray
        Me.CSPName.Location = New System.Drawing.Point(8, 28)
        Me.CSPName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CSPName.Name = "CSPName"
        Me.CSPName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CSPName.Size = New System.Drawing.Size(299, 37)
        Me.CSPName.TabIndex = 20
        Me.CSPName.Text = "Nome da Probe"
        Me.CSPName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CSPName.Visible = False
        '
        'lblQtdMedidas
        '
        Me.lblQtdMedidas.BackColor = System.Drawing.Color.SkyBlue
        Me.lblQtdMedidas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQtdMedidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdMedidas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQtdMedidas.Location = New System.Drawing.Point(985, 406)
        Me.lblQtdMedidas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQtdMedidas.Name = "lblQtdMedidas"
        Me.lblQtdMedidas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQtdMedidas.Size = New System.Drawing.Size(147, 64)
        Me.lblQtdMedidas.TabIndex = 46
        Me.lblQtdMedidas.Text = "Qtd. Medidas:"
        Me.lblQtdMedidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaiorValor1
        '
        Me.lblMaiorValor1.BackColor = System.Drawing.Color.SkyBlue
        Me.lblMaiorValor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaiorValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaiorValor1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaiorValor1.Location = New System.Drawing.Point(985, 474)
        Me.lblMaiorValor1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaiorValor1.Name = "lblMaiorValor1"
        Me.lblMaiorValor1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaiorValor1.Size = New System.Drawing.Size(147, 64)
        Me.lblMaiorValor1.TabIndex = 45
        Me.lblMaiorValor1.Text = "0"
        Me.lblMaiorValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValorMedio
        '
        Me.lblValorMedio.BackColor = System.Drawing.Color.SkyBlue
        Me.lblValorMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblValorMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblValorMedio.Location = New System.Drawing.Point(985, 677)
        Me.lblValorMedio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorMedio.Name = "lblValorMedio"
        Me.lblValorMedio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblValorMedio.Size = New System.Drawing.Size(147, 64)
        Me.lblValorMedio.TabIndex = 44
        Me.lblValorMedio.Text = "Valor Médio:"
        Me.lblValorMedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstValores
        '
        Me.lstValores.BackColor = System.Drawing.Color.SkyBlue
        Me.lstValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstValores.FormatString = "N0"
        Me.lstValores.FormattingEnabled = True
        Me.lstValores.ItemHeight = 29
        Me.lstValores.Location = New System.Drawing.Point(987, 129)
        Me.lstValores.Margin = New System.Windows.Forms.Padding(4)
        Me.lstValores.Name = "lstValores"
        Me.lstValores.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstValores.Size = New System.Drawing.Size(141, 265)
        Me.lstValores.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSuperficie)
        Me.GroupBox1.Controls.Add(Me.txtMetro)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 422)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(556, 215)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doses"
        '
        'txtIt
        '
        Me.txtIt.Enabled = False
        Me.txtIt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIt.ForeColor = System.Drawing.Color.Black
        Me.txtIt.Location = New System.Drawing.Point(303, 169)
        Me.txtIt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIt.Name = "txtIt"
        Me.txtIt.Size = New System.Drawing.Size(237, 37)
        Me.txtIt.TabIndex = 3
        Me.txtIt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "I.T.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSuperficie
        '
        Me.txtSuperficie.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuperficie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSuperficie.Location = New System.Drawing.Point(303, 28)
        Me.txtSuperficie.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuperficie.MaxLength = 11
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.Size = New System.Drawing.Size(237, 82)
        Me.txtSuperficie.TabIndex = 1
        Me.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMetro
        '
        Me.txtMetro.Enabled = False
        Me.txtMetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMetro.ForeColor = System.Drawing.Color.Black
        Me.txtMetro.Location = New System.Drawing.Point(303, 122)
        Me.txtMetro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMetro.Name = "txtMetro"
        Me.txtMetro.Size = New System.Drawing.Size(237, 37)
        Me.txtMetro.TabIndex = 2
        Me.txtMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 50)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 48)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Superfície(µSv/h):"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 116)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(251, 48)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "1 Metro(µSv/h):"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(11, 30)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(952, 57)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Navy
        Me.btnConfirmar.Location = New System.Drawing.Point(315, 747)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(457, 97)
        Me.btnConfirmar.TabIndex = 40
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblStatus)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(12, 642)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(968, 97)
        Me.GroupBox8.TabIndex = 48
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Status"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblEtiqueta)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(573, 421)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(407, 111)
        Me.GroupBox7.TabIndex = 47
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Etiqueta"
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.BackColor = System.Drawing.SystemColors.Control
        Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.ForeColor = System.Drawing.Color.Navy
        Me.lblEtiqueta.Location = New System.Drawing.Point(12, 34)
        Me.lblEtiqueta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(384, 63)
        Me.lblEtiqueta.TabIndex = 6
        Me.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Navy
        Me.btnLimpar.Location = New System.Drawing.Point(9, 16)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(131, 39)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Navy
        Me.btnSair.Location = New System.Drawing.Point(9, 60)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(131, 39)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnFecharMensagem
        '
        Me.btnFecharMensagem.BackColor = System.Drawing.Color.Red
        Me.btnFecharMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharMensagem.Location = New System.Drawing.Point(1093, 7)
        Me.btnFecharMensagem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFecharMensagem.Name = "btnFecharMensagem"
        Me.btnFecharMensagem.Size = New System.Drawing.Size(33, 25)
        Me.btnFecharMensagem.TabIndex = 51
        Me.btnFecharMensagem.Text = "X"
        Me.btnFecharMensagem.UseVisualStyleBackColor = False
        '
        'lblDose
        '
        Me.lblDose.BackColor = System.Drawing.SystemColors.Control
        Me.lblDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDose.ForeColor = System.Drawing.Color.Navy
        Me.lblDose.Location = New System.Drawing.Point(17, 36)
        Me.lblDose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDose.Name = "lblDose"
        Me.lblDose.Size = New System.Drawing.Size(244, 75)
        Me.lblDose.TabIndex = 6
        Me.lblDose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMensagem
        '
        Me.lblMensagem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.ForeColor = System.Drawing.Color.Black
        Me.lblMensagem.Location = New System.Drawing.Point(15, 7)
        Me.lblMensagem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(1112, 94)
        Me.lblMensagem.TabIndex = 50
        Me.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpar)
        Me.GroupBox3.Controls.Add(Me.btnSair)
        Me.GroupBox3.Location = New System.Drawing.Point(984, 738)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(148, 108)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblDose)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(708, 293)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(272, 128)
        Me.GroupBox6.TabIndex = 46
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dose média(µSv/h)"
        '
        'lblAtividade
        '
        Me.lblAtividade.BackColor = System.Drawing.SystemColors.Control
        Me.lblAtividade.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtividade.ForeColor = System.Drawing.Color.Navy
        Me.lblAtividade.Location = New System.Drawing.Point(8, 36)
        Me.lblAtividade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtividade.Name = "lblAtividade"
        Me.lblAtividade.Size = New System.Drawing.Size(199, 75)
        Me.lblAtividade.TabIndex = 6
        Me.lblAtividade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.ForeColor = System.Drawing.Color.Navy
        Me.txtLote.Location = New System.Drawing.Point(9, 49)
        Me.txtLote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLote.MaxLength = 11
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(463, 114)
        Me.txtLote.TabIndex = 0
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grbDose
        '
        Me.grbDose.Controls.Add(Me.txtLote)
        Me.grbDose.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDose.ForeColor = System.Drawing.Color.Black
        Me.grbDose.Location = New System.Drawing.Point(12, 107)
        Me.grbDose.Margin = New System.Windows.Forms.Padding(4)
        Me.grbDose.Name = "grbDose"
        Me.grbDose.Padding = New System.Windows.Forms.Padding(4)
        Me.grbDose.Size = New System.Drawing.Size(481, 177)
        Me.grbDose.TabIndex = 41
        Me.grbDose.TabStop = False
        Me.grbDose.Text = "Lote/Número"
        '
        'lblMaterial
        '
        Me.lblMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.ForeColor = System.Drawing.Color.Navy
        Me.lblMaterial.Location = New System.Drawing.Point(13, 30)
        Me.lblMaterial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(447, 91)
        Me.lblMaterial.TabIndex = 6
        Me.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'lblUltimoLote
        '
        Me.lblUltimoLote.BackColor = System.Drawing.SystemColors.Control
        Me.lblUltimoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 56.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimoLote.ForeColor = System.Drawing.Color.Purple
        Me.lblUltimoLote.Location = New System.Drawing.Point(11, 47)
        Me.lblUltimoLote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUltimoLote.Name = "lblUltimoLote"
        Me.lblUltimoLote.Size = New System.Drawing.Size(459, 108)
        Me.lblUltimoLote.TabIndex = 6
        Me.lblUltimoLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblAtividade)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(488, 293)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(215, 128)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Atividade(mCi)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblUltimoLote)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(501, 107)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(479, 177)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Último lote"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMaterial)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(471, 128)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 7)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1115, 65)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "MONITORAÇÃO DE EMBALADOS RADIOATIVOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sonda
        '
        Me.Sonda.Controls.Add(Me.lblComunicacaoSonda)
        Me.Sonda.Controls.Add(Me.btnResetSonda)
        Me.Sonda.Controls.Add(Me.CSPName)
        Me.Sonda.Controls.Add(Me.Mode)
        Me.Sonda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Sonda.ForeColor = System.Drawing.Color.Black
        Me.Sonda.Location = New System.Drawing.Point(573, 533)
        Me.Sonda.Margin = New System.Windows.Forms.Padding(4)
        Me.Sonda.Name = "Sonda"
        Me.Sonda.Padding = New System.Windows.Forms.Padding(4)
        Me.Sonda.Size = New System.Drawing.Size(405, 105)
        Me.Sonda.TabIndex = 52
        Me.Sonda.TabStop = False
        Me.Sonda.Text = "Sonda"
        '
        'btnResetSonda
        '
        Me.btnResetSonda.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetSonda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSonda.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnResetSonda.Location = New System.Drawing.Point(309, 25)
        Me.btnResetSonda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetSonda.Name = "btnResetSonda"
        Me.btnResetSonda.Size = New System.Drawing.Size(93, 75)
        Me.btnResetSonda.TabIndex = 7
        Me.btnResetSonda.Text = "Reset Sonda"
        Me.btnResetSonda.UseVisualStyleBackColor = False
        '
        'lblMaiorValor3
        '
        Me.lblMaiorValor3.BackColor = System.Drawing.Color.SkyBlue
        Me.lblMaiorValor3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaiorValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaiorValor3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaiorValor3.Location = New System.Drawing.Point(985, 609)
        Me.lblMaiorValor3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaiorValor3.Name = "lblMaiorValor3"
        Me.lblMaiorValor3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaiorValor3.Size = New System.Drawing.Size(147, 64)
        Me.lblMaiorValor3.TabIndex = 53
        Me.lblMaiorValor3.Text = "0"
        Me.lblMaiorValor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaiorValor2
        '
        Me.lblMaiorValor2.BackColor = System.Drawing.Color.SkyBlue
        Me.lblMaiorValor2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaiorValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaiorValor2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaiorValor2.Location = New System.Drawing.Point(985, 542)
        Me.lblMaiorValor2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaiorValor2.Name = "lblMaiorValor2"
        Me.lblMaiorValor2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaiorValor2.Size = New System.Drawing.Size(147, 64)
        Me.lblMaiorValor2.TabIndex = 54
        Me.lblMaiorValor2.Text = "0"
        Me.lblMaiorValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMonitorarEmbalados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1160, 746)
        Me.Controls.Add(Me.lblMaiorValor2)
        Me.Controls.Add(Me.lblMaiorValor3)
        Me.Controls.Add(Me.Sonda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblQtdMedidas)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lblMaiorValor1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.lblValorMedio)
        Me.Controls.Add(Me.lstValores)
        Me.Controls.Add(Me.btnFecharMensagem)
        Me.Controls.Add(Me.lblMensagem)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.grbDose)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMonitorarEmbalados"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONITORAÇÃO DE EMBALADOS RADIOATIVOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MeasFrame.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me.CountFrame.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.CritFrame.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.UnitSys.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.grbDose.ResumeLayout(False)
        Me.grbDose.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Sonda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstValores As System.Windows.Forms.ListBox
    Public WithEvents lblQtdMedidas As System.Windows.Forms.Label
    Public WithEvents lblMaiorValor1 As System.Windows.Forms.Label
    Public WithEvents lblValorMedio As System.Windows.Forms.Label
    Public WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSuperficie As System.Windows.Forms.TextBox
    Friend WithEvents txtMetro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEtiqueta As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnFecharMensagem As System.Windows.Forms.Button
    Friend WithEvents lblDose As System.Windows.Forms.Label
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAtividade As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents grbDose As System.Windows.Forms.GroupBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Public WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblUltimoLote As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Sonda As System.Windows.Forms.GroupBox
    Friend WithEvents btnResetSonda As System.Windows.Forms.Button
    Public WithEvents lblMaiorValor3 As System.Windows.Forms.Label
    Public WithEvents lblMaiorValor2 As System.Windows.Forms.Label
#End Region
End Class