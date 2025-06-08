Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Math
Imports System
Imports System.Drawing


Friend Class frmMonitorarEmbalados
    Inherits System.Windows.Forms.Form
    'UPGRADE_NOTE: CSPCom was upgraded to CSPCom_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Dim CSPCom_Renamed As Integer
    Public Common As Header
    Dim UnitType As Short
    Dim Zone As Integer
    Dim Pos As Integer
    Dim Channel As Integer
    Dim Tabl_Alrm_Lvl(19) As Single
    Dim Tabl_Alrm_Lvl_Idx As Byte
    Dim Tabl_Unit(9) As Byte
    Dim TempLong As Integer
    Dim CSPParam As Param_Fonc
    Dim ElectroMeas As ELECMEAS
    'UPGRADE_WARNING: Arrays in structure CriticParam may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
    Dim CriticParam As CRIT_PARAM
    Dim TempIndex As Integer
    Dim Temp As Integer
    Dim Version(2) As Byte
    Dim ReadCount As Boolean
    'UPGRADE_NOTE: Rate was upgraded to Rate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Dim Rate_Renamed As Short
    Dim Count_1 As Integer
    Dim Count_2 As Integer
    Dim pCount1 As Integer
    Dim pCount2 As Integer

    Public QuantidadeLeituras As Integer
    Public SomaTotalValores As Integer
    Public MaiorValor As Integer

    Dim Etiqueta As Integer

    Private Sub frmMonitorarEmbalados_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim File As String

        Try

        
            ReadCount = False
            Rate_Renamed = 0
            Common.ClientAdr = 0
            Common.Status = 0
            Common.Emis = 132    ' solda gamma 132 0x084
            Common.Master = 132
            Zone = 0
            TempIndex = 100
            Channel = 1

            CSPCom_Renamed = Initialize()

            Count_1 = 0
            Count_2 = 0

            SetErrName(CSPCom_Renamed, 1)

            File = New String(vbNullChar, 255)
            GetLogName(CSPCom_Renamed, File)
            Fichier.Text = File

            Call Limpar()
            Call AbrirSonda()

        Catch ex As Exception

        End Try
    End Sub

    Private Function UnitDisplay(ByRef UnitCode As Integer) As String
        Dim Units(21) As String

        Try
            Units(0) = "c/s"
            Units(1) = "CPM"
            Units(2) = "Bqeq"
            Units(3) = "DPMeq"
            Units(4) = "Bqeq/cm²"
            Units(5) = "DPMeq/100cm²"
            Units(6) = "c/s"
            Units(7) = "CPS"
            Units(8) = "Sveq"
            Units(9) = "R"
            Units(10) = "Sveq/h"
            Units(11) = "R/h"
            Units(12) = "Sv"
            Units(13) = "rem"
            Units(14) = "Sv/h"
            Units(15) = "rem/h"
            Units(16) = "Sv"
            Units(17) = "rem"
            Units(18) = "Sv/h"
            Units(19) = "rem/h"
            Units(20) = "c/s"
            Units(21) = "CPM"

            If (UnitCode >= 0) And (UnitCode < 22) Then
                UnitDisplay = Units(UnitCode)
            Else
                UnitDisplay = "N/A"
            End If

        Catch ex As Exception

        End Try

    End Function

    ' Fonction traduisant le code des noms de sonde
    Private Function NameDisplay(ByRef CodeName As Integer) As String
        Try

            'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            NameDisplay = VB.Switch(CodeName = 129, "CSP Alpha", CodeName = 130, "CSP Beta", CodeName = 132, "CSP Gamma", CodeName = 144, "CSP X", CodeName = 160, "CSP Spectro", CodeName = 193, "CSP Alpha+Beta Mixte")

        Catch ex As Exception

        End Try
    End Function

    ' Fonction traduisant le code des types de sonde
    Private Function TypeDisplay(ByRef CodeName As Integer) As String
        Try
            'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            TypeDisplay = VB.Switch(CodeName = 0, "Gamma", CodeName = 1, "Alpha", CodeName = 2, "Beta", CodeName = 3, "Alpha+Beta", CodeName = 4, "Alpha+Beta+Gamma", CodeName = 5, "Neutron", CodeName = 6, "Neutron+Gamma", CodeName = 7, "X")

        Catch ex As Exception

        End Try
    End Function

    ' Fonction traduisant le code des modes de fonctionnements
    Private Function ModeDisplay(ByRef CodeMode As Integer) As String
        Try
            'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ModeDisplay = VB.Switch(CodeMode = 0, "", CodeMode = 1, "Mode Alpha", CodeMode = 2, "Mode Beta", CodeMode = 3, "Mode Alpha+Beta", CodeMode = 4, "Discriminateur en énergie", CodeMode = 8, "Générateur test interne", CodeMode = 16, "Comptage Net", CodeMode = 32, "Led")

        Catch ex As Exception

        End Try
    End Function

    Private Function Checking(ByRef Check As Short) As Boolean
        Dim ErrMsg As String

        Try
            ErrMsg = New String(vbNullChar, 255)
            GetLastErrorMsg(CSPCom_Renamed, ErrMsg)
            lblComunicacaoSonda.Text = ErrMsg
            ErrMsg = New String(vbNullChar, 0)
            If Check = 0 Then
                Checking = False
            Else
                Checking = True
            End If

        Catch ex As Exception

        End Try

    End Function

    'UPGRADE_WARNING: Event Alrm_Lvl.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Alrm_Lvl_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alrm_Lvl.SelectedIndexChanged
        Try
            Index.Enabled = True
            TempIndex = Alrm_Lvl.SelectedIndex
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Index_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Index.Click
        Try
            InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
            If (IsNumeric(Alrm_Lvl.Text)) And (TempIndex <> 100) Then
                If CSng(Alrm_Lvl.Text) <> Tabl_Alrm_Lvl(2 * TempIndex + 1) Then
                    Checking(SetAlrmLvlArray(CSPCom_Renamed, CSng(Alrm_Lvl.Text), VB6.GetItemData(Unit, Unit.SelectedIndex), TempIndex))
                    Tabl_Alrm_Lvl(2 * TempIndex + 1) = CSng(Alrm_Lvl.Text)
                End If
                If (TempIndex <> Tabl_Alrm_Lvl_Idx) Then
                    VB6.SetItemString(Alrm_Lvl, Tabl_Alrm_Lvl_Idx, CStr(Tabl_Alrm_Lvl(2 * Tabl_Alrm_Lvl_Idx + 1)))
                    Tabl_Alrm_Lvl_Idx = TempIndex
                    Checking(SetAlrmLvlIndexArray(CSPCom_Renamed, CByte(TempIndex), Channel, VB6.GetItemData(Unit, Unit.SelectedIndex)))
                End If
                ReadAlarmLevels()
            End If
            CloseComm(CSPCom_Renamed)
            Index.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Modif_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modif.Click
        Fichier.Enabled = True
        Fichier.Focus()
    End Sub

    Private Sub ReadCritParam_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ReadCritParam.Click
        ReDim CriticParam.CalibChannel(0)
        'ReDim CriticParam.CalibChannel(1)
        Try
            CriticParam.Initialize()
            CriticParam.Identif.Name = New String(vbNullChar, 7)
            CriticParam.Identif.PROBE_TYPE = New String(vbNullChar, 20)
            CriticParam.CalibChannel(0).Emitter = New String(vbNullChar, 10)
            CriticParam.CalibChannel(0).RefSource = New String(vbNullChar, 10)
            'CriticParam.CalibChannel(1).Emitter = New String(vbNullChar, 10)
            'CriticParam.CalibChannel(1).RefSource = New String(vbNullChar, 10)
            InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
            GetCriticalParameter(CSPCom_Renamed, CriticParam)
            If (Checking(GetCriticalParameter(CSPCom_Renamed, CriticParam))) Then
                RefSource.Text = CriticParam.CalibChannel(0).RefSource
                Emitter1.Text = CriticParam.CalibChannel(0).Emitter
            End If
            CloseComm(CSPCom_Renamed)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim Data As String
        Dim datype As String
        Dim i As Integer
        Dim xValorMedio As Integer

        Try
            pCount1 = 0
            pCount2 = 0

            Rate_Renamed = Rate_Renamed + 1
            Checking(GetCount(CSPCom_Renamed, pCount1, pCount2))
            Count_1 = Count_1 + pCount1
            Count_2 = Count_2 + pCount2
            If Rate_Renamed = 4 Then
                If QuantidadeLeituras < NumeroContagem Then
                    QuantidadeLeituras += 1
                End If

                Rate_Renamed = 0
                Count1.Text = CStr(Count_1)
                Count2.Text = CStr(Count_2)
                Data = "Count Channel 2 "

                SaveData(CSPCom_Renamed, Data, CStr(Count_2))


                ' Adicionar valores na lstValores
                'SomaTotalValores += CInt(Count_2)
                lstValores.Items.Add(CInt(Count2.Text))

                lblQtdMedidas.Text = "Qtd. Medidas: " & CStr(QuantidadeLeituras)

                Dim xValorMenor As Integer

                If CInt(lblMaiorValor3.Text) < CInt(lblMaiorValor2.Text) Then
                    xValorMenor = CInt(lblMaiorValor3.Text)
                    lblMaiorValor3.Text = CInt(lblMaiorValor2.Text)
                    lblMaiorValor2.Text = xValorMenor
                End If

                If CInt(lblMaiorValor2.Text) < CInt(lblMaiorValor1.Text) Then
                    xValorMenor = CInt(lblMaiorValor2.Text)
                    lblMaiorValor2.Text = CInt(lblMaiorValor1.Text)
                    lblMaiorValor1.Text = xValorMenor
                End If


                If CInt(lblMaiorValor1.Text) = 0 Then
                    lblMaiorValor1.Text = Count_2
                ElseIf CInt(lblMaiorValor2.Text) = 0 Then
                    lblMaiorValor2.Text = Count_2
                ElseIf CInt(lblMaiorValor3.Text) = 0 Then
                    lblMaiorValor3.Text = Count_2
                Else
                    If Count_2 > CInt(lblMaiorValor1.Text) Then
                        lblMaiorValor1.Text = Count_2
                    End If
                End If
                SomaTotalValores = CInt(lblMaiorValor1.Text) + CInt(lblMaiorValor2.Text) + CInt(lblMaiorValor3.Text)
                xValorMedio = CStr(Round(CInt(SomaTotalValores / 3), 0))
                'lblValorMedio.Text = "Valor Médio: " & CStr(Round(CDbl(SomaTotalValores / 3), 0))
                lblValorMedio.Text = "Valor Médio: " & xValorMedio

                If QuantidadeLeituras >= CInt(NumeroContagem) Then
                    txtSuperficie.Text = xValorMedio
                    Timer1.Enabled = False
                    Checking(CloseComm(CSPCom_Renamed))
                    ReadCount = False
                    Call Confirmar()
                End If

                Count1.Text = pCount1
                Count2.Text = pCount2

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UnitSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UnitSet.Click

        Try
            Rate_Renamed = 0
            Common.ClientAdr = 0
            Common.Status = 0
            Common.Emis = 132    ' solda gamma 132 0x084
            Common.Master = 132
            Zone = 0
            TempIndex = 100
            Channel = 1
            Checking(InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100))
            If VB6.GetItemData(Unit, Temp) <> CSPParam.UnitCode Then
                Checking(SetUnit(CSPCom_Renamed, VB6.GetItemData(Unit, Temp)))
            End If
            Checking(GetCurrentParam(CSPCom_Renamed, CSPParam))
            ReadUnits(UnitType)
            CloseComm(CSPCom_Renamed)
            UnitSet.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadAlarmLevels()
        Dim i As Object
        Dim Level As String

        Try
            If Checking(GetAlrmLvlIndexArray(CSPCom_Renamed, Tabl_Alrm_Lvl_Idx, Channel, VB6.GetItemData(Unit, Unit.SelectedIndex))) Then
                If Checking(GetAlrmLvlArray(CSPCom_Renamed, Tabl_Alrm_Lvl(0), VB6.GetItemData(Unit, Unit.SelectedIndex), 0)) Then
                    Alrm_Lvl.Items.Clear()
                    For i = 0 To 9
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Level = CStr(Tabl_Alrm_Lvl(2 * i + 1))
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If i = CInt(Tabl_Alrm_Lvl_Idx) Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            VB6.SetItemString(Alrm_Lvl, i, Level & " (i)")
                        Else
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            VB6.SetItemString(Alrm_Lvl, i, Level)
                        End If
                    Next
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    'UPGRADE_WARNING: Event Unit.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Unit_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Unit.SelectedIndexChanged

        Try

            InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
            'ReadAlarmLevels()   Comentado mauro
            CloseComm(CSPCom_Renamed)
            UnitSet.Enabled = True
            Temp = Unit.SelectedIndex

        Catch ex As Exception

        End Try

    End Sub

    Private Sub WriteIndex_Click()
        Dim WriteIndex As Object
        Dim AlarmLvl As Object
        Dim NewVal As Object

        Try
            InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
            'UPGRADE_WARNING: Couldn't resolve default property of object AlarmLvl.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If IsNumeric(AlarmLvl.Text) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object NewVal.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SetAlrmLvlArray(CSPCom_Renamed, CSng(NewVal.Text), Unit.SelectedIndex, Alrm_Lvl.SelectedIndex)
            Else
                lblComunicacaoSonda.Text = "Cannot change Alarm Level : Non Numeric Value"
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object WriteIndex.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WriteIndex.Enabled = False
            CloseComm(CSPCom_Renamed)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Save_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Save.Click
        Try
            If (Fichier.Enabled) Then
                Fichier.Enabled = False
            End If
            SetLog(CSPCom_Renamed, (Fichier.Text), CInt(List1.TopIndex))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CommStatus_Click()

        Try

            InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
            If GetCommInit(CSPCom_Renamed) = 0 Then
                lblComunicacaoSonda.Text = "Erro de Comunicação com a Sonda"
            Else
                lblComunicacaoSonda.Text = ""
            End If
            Checking(CloseComm(CSPCom_Renamed))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReadUnits(ByRef UnitType As Short)
        Unit.Enabled = True
        Dim TempUnit As String

        Try
            If Checking(GetUnitArray(CSPCom_Renamed, Tabl_Unit(0), UnitType, 0)) Then
                Unit.Items.Clear()
                Temp = 0
                Checking(GetCurrentParam(CSPCom_Renamed, CSPParam))
                Do While (CInt(Tabl_Unit(Temp)) < 22) And (Temp < 10)
                    TempLong = CInt(Tabl_Unit(Temp))
                    TempUnit = UnitDisplay(TempLong)
                    If TempLong = CSPParam.UnitCode Then
                        TempUnit = TempUnit & " (i)"
                    End If
                    'Unit.SelectedValue = TempUnit
                    VB6.SetItemString(Unit, Temp, TempUnit)
                    'UPGRADE_ISSUE: ComboBox property Unit.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
                    'VB6.SetItemData(Unit, Unit.Items.NewIndex, TempLong)
                    Temp = Temp + 1
                Loop
            End If

        Catch ex As Exception

        End Try

    End Sub


    'UPGRADE_WARNING: Event SI.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    'Private Sub SI_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SI.CheckedChanged
    '    If eventSender.Checked Then
    '        UnitType = 0
    '        InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
    '        ReadUnits(UnitType)
    '        CloseComm(CSPCom_Renamed)
    '    End If
    'End Sub

    ''UPGRADE_WARNING: Event US.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    'Private Sub US_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles US.CheckedChanged
    '    If eventSender.Checked Then
    '        UnitType = 1
    '        InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)
    '        ReadUnits(UnitType)
    '        CloseComm(CSPCom_Renamed)
    '    End If
    'End Sub



    Private Sub Limpar()
        MaiorValor = 0
        SomaTotalValores = 0
        QuantidadeLeituras = 0

        Count_1 = 0
        Count_2 = 0
        txtIt.Text = ""
        txtMetro.Text = ""
        txtSuperficie.Text = ""
        txtLote.Text = ""
        lblAtividade.Text = ""
        lblDose.Text = ""
        lblEtiqueta.Text = ""
        lblMaterial.Text = ""
        lblStatus.Text = ""
        'btnFecharMensagem.Visible = False
        'lblMensagem.Visible = False
        btnConfirmar.BackColor = Color.LightCoral
        btnConfirmar.Visible = False
        lstValores.Items.Clear()
        lblMaiorValor1.Text = "0"
        lblMaiorValor2.Text = "0"
        lblMaiorValor3.Text = "0"
        lblQtdMedidas.Text = "Qtd. Medidas:"
        lblValorMedio.Text = "Valor Médio:"
        Etiqueta = 0
        txtLote.Focus()


    End Sub

    Private Sub txtLote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLote.LostFocus

        Try

            If txtLote.Text = "" Then Exit Sub

            txtLote.BackColor = Color.White

            If txtLote.Text.Substring(0, 9).ToString.ToUpper = Trim(lblUltimoLote.Text) Then
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If

            If txtLote.Text <> "" And CInt(Len(txtLote.Text)) = 11 Then
                lblMensagem.Text = ""
                'lblMensagem.BackColor = Color.White
                'lblMensagem.Visible = False
                'btnFecharMensagem.Visible = False
                lblUltimoLote.Text = txtLote.Text.Substring(0, 9).ToString.ToUpper
                lstValores.Items.Clear()
                lblMaiorValor1.Text = "0"
                lblMaiorValor2.Text = "0"
                lblMaiorValor3.Text = "0"
                lblQtdMedidas.Text = "Qtd. Medidas:"
                lblValorMedio.Text = "Valor Médio:"
                Call CarregarPagina()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CarregarPagina()
        Dim xChave As New AcessoDados.clsMonitorar
        Dim rsTabela As New DataSet

        Try
            MaiorValor = 0
            SomaTotalValores = 0
            QuantidadeLeituras = 0

            Label17.Visible = True

            xChave.Chave = txtLote.Text.Substring(0, 9).ToString.ToUpper

            rsTabela = xChave.BuscaChave

            If rsTabela.Tables(0).Rows.Count = 0 Then
                lblMensagem.BackColor = Color.Red
                lblMensagem.Visible = True
                lblMensagem.Text = "NÚMERO DE EMBALADO NÃO ENCONTRADO!"
                btnFecharMensagem.Visible = True
                MsgBox("NÚMERO DE EMBALADO NÃO ENCONTRADO!", MsgBoxStyle.Exclamation)
                txtLote.Focus()
                Exit Sub
            End If

            With rsTabela.Tables("LISTA").Rows(0)
                If CInt(.Item("resulta").ToString) = 1 Then
                    lblMensagem.BackColor = Color.Red
                    lblMensagem.Visible = True
                    lblMensagem.Text = .Item("mensa").ToString
                    btnFecharMensagem.Visible = True
                    MsgBox(.Item("mensa").ToString, MsgBoxStyle.Critical)
                    txtLote.Text = ""
                    txtLote.Focus()
                    Exit Sub
                End If

                If .Item("resultadoid") = 0 Or .Item("resultadoid") = 2 Then
                    lblMensagem.BackColor = Color.Red
                    lblMensagem.Visible = True
                    lblMensagem.Text = .Item("resultado").ToString
                    btnFecharMensagem.Visible = True
                    MsgBox(.Item("resultado").ToString, MsgBoxStyle.Critical)
                    txtLote.Text = ""
                    txtLote.Focus()

                    btnConfirmar.Visible = False
                    Exit Sub
                End If

                If .Item("resultadoid") = 1 Or .Item("resultadoid") = 3 Then
                    btnConfirmar.Visible = True
                    btnConfirmar.BackColor = Color.LightCoral
                End If

                lblMaterial.Text = .Item("prod_descricao").ToString
                lblAtividade.Text = .Item("p110atv").ToString
                lblDose.Text = .Item("p110atcx").ToString
                lblStatus.Text = .Item("resultado").ToString
                lblEtiqueta.Text = .Item("etq_texto").ToString
                txtMetro.Text = (.Item("p110at1m").ToString) / 10
                txtIt.Text = .Item("p110it").ToString

                Etiqueta = CInt(.Item("etq").ToString)

                If CInt(.Item("etq").ToString) = 1 Then
                    lblEtiqueta.BackColor = Color.White
                Else
                    lblEtiqueta.BackColor = Color.Yellow
                End If
                Threading.Thread.Sleep(1600)
                Call Monitorar()
            End With

            txtSuperficie.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Confirmar()
        Dim Executor As New AcessoDados.clsMonitorar
        Dim rsTabela As New DataSet
        Dim Documento As String
        Dim i As Integer
        Dim CaminhoGravarTxt As String
        Dim ImpressoraEsteira As String
        Dim ImpressoraBND As String
        Dim ImpressoraREM As String
        Dim ImpressoraHVL As String
        Dim ImpressoraCR As String
        Dim xP110fisc As Integer
        Dim xP110id As Integer
        Dim xChave As String
        Dim xNotafis_oid As Integer
        Dim Formato As System.Text.Encoding
        Formato = System.Text.Encoding.Default
        Dim Texto
        Dim xTaxaSuperficie As String



        'MsgBox(txtSuperficie.Text)
        'Limpar()
        'Exit Sub

        If CInt(txtSuperficie.Text) >= 500 And CInt(txtSuperficie.Text) < 600 And CInt(Etiqueta) = 2 Then
            txtSuperficie.Text = 480
        End If


        CaminhoGravarTxt = "C:\TXT\"
        ImpressoraEsteira = "\\SAURA\ENTRADA_ESTEIRA"
        ImpressoraBND = "\\SAURA\BND"
        ImpressoraREM = "\\SAURA\REM"
        ImpressoraHVL = "\\SAURA\HVL"
        ImpressoraCR = "\\SAURA\ENTRADA"

        Try

            If Trim(txtLote.Text) = "" Or Trim(txtSuperficie.Text) = "" Then
                Label17.Visible = False
                lblMensagem.BackColor = Color.Red
                lblMensagem.Visible = True
                lblMensagem.Text = "OCORREU UM ERRO NA GRAVAÇÃO DESTE EMBALADO!"
                btnFecharMensagem.Visible = True
                MsgBox("LEIA NOVAMENTE O EMBALADO!", MsgBoxStyle.Information)
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If

            xChave = txtLote.Text.Substring(0, 9).ToString.ToUpper

            If CInt(txtSuperficie.Text) = 0 And CInt(Etiqueta) = 1 Then
                txtIt.Text = 0
            ElseIf CInt(txtSuperficie.Text) = 0 And CInt(Etiqueta) > 1 Then
                Label17.Visible = False
                lblMensagem.Visible = True
                lblMensagem.Text = "EFETUE A MONITORAÇÃO NOVAMENTE! TAXA NA SUPERFÍCIE ESTÁ IGUAL A ZERO E ETIQUETA ESTÁ RADIOATIVO " & CStr(Etiqueta)
                btnFecharMensagem.Visible = True
                MsgBox("EFETUE A MONITORAÇÃO NOVAMENTE! TAXA NA SUPERFÍCIE ESTÁ IGUAL A ZERO E ETIQUETA ESTÁ RADIOATIVO " & CStr(Etiqueta), MsgBoxStyle.Critical)
                'lblMensagem.Visible = False
                'lblMensagem.Text = ""
                'btnFecharMensagem.Visible = False
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If


            'If txtLote.Text.Substring(3, 2).ToString.ToUpper() = "FL" Or txtLote.Text.Substring(3, 2).ToString.ToUpper() = "FN" Or txtLote.Text.Substring(3, 2).ToString.ToUpper() = "DG" Then
            '    Label17.Visible = False
            'Else
            '    If CInt(Etiqueta) <> 1 Then
            '        If CInt(txtSuperficie.Text) < (CInt(lblDose.Text) * 0.6) Then
            '            Label17.Visible = False
            '            lblMensagem.Visible = True
            '            lblMensagem.Text = "TAXA NA SUPERFÍCIE ESTÁ MUITO BAIXA! MONITORE NOVAMENTE OU INFORME A PRODUÇÃO! TAXA APRESENTADA: " & CStr(txtSuperficie.Text) & "; MÉDIA: " & CStr(lblDose.Text)
            '            'btnFecharMensagem.Visible = True
            '            'Threading.Thread.Sleep(100)
            '            MsgBox("TAXA NA SUPERFÍCIE ESTÁ MUITO BAIXA! MONITORE NOVAMENTE OU INFORME A PRODUÇÃO! TAXA APRESENTADA: " & CStr(txtSuperficie.Text) & "; MÉDIA: " & CStr(lblDose.Text), MsgBoxStyle.Critical)
            '            txtLote.Text = ""
            '            txtLote.Focus()
            '            Exit Sub
            '        End If
            '    End If
            'End If


            If CInt(txtSuperficie.Text) >= 2000 Then
                Label17.Visible = False
                lblMensagem.BackColor = Color.Red
                lblMensagem.Visible = True
                lblMensagem.Text = "PARA ESTA TAXA DE DOSE NA SUPERFÍCIE DEVERÁ SER UTILIZADO EMBARQUE ESPECIAL! EMISSÃO NÃO PERMITIDA!"
                'btnFecharMensagem.Visible = True
                MsgBox("PARA ESTA TAXA DE DOSE NA SUPERFÍCIE DEVERÁ SER UTILIZADO EMBARQUE ESPECIAL! EMISSÃO NÃO PERMITIDA!", MsgBoxStyle.Critical)
                txtSuperficie.Text = ""
                txtSuperficie.Focus()
                Exit Sub
            End If

            xTaxaSuperficie = txtSuperficie.Text

            'Executor.Dose1m = CInt(txtMetro.Text)
            Executor.Dosecx = CInt(txtSuperficie.Text)
            Executor.It = txtIt.Text
            Executor.Etq = CInt(Etiqueta)
            Executor.Chave = xChave

            rsTabela = Executor.GravaChave

            If rsTabela.Tables("PEDIDO_IT").Rows.Count = 0 Then
                Label17.Visible = False
                lblMensagem.BackColor = Color.Red
                lblMensagem.Visible = True
                lblMensagem.Text = "OCORREU UM ERRO NA GRAVAÇÃO DESTE EMBALADO!"
                btnFecharMensagem.Visible = True
                MsgBox("OCORREU UM ERRO NA GRAVAÇÃO DESTE EMBALADO!", MsgBoxStyle.Critical)
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If

            With rsTabela.Tables("PEDIDO_IT").Rows(0)
                If CInt(.Item("RESULTA").ToString) <> 99 Then
                    Label17.Visible = False
                    lblMensagem.BackColor = Color.Red
                    lblMensagem.Visible = True
                    lblMensagem.Text = .Item("mensa").ToString
                    btnFecharMensagem.Visible = True
                    MsgBox(.Item("mensa").ToString, MsgBoxStyle.Critical)
                    txtLote.Text = ""
                    txtLote.Focus()
                    Exit Sub
                Else
                    xP110id = CInt(.Item("p110id").ToString)
                    xP110fisc = CInt(.Item("p110fisc").ToString)
                    xNotafis_oid = CInt(.Item("notafis_oid").ToString)
                End If
            End With

            Executor.P110id = xP110id
            Executor.P110fisc = xP110fisc
            Executor.Notafis_oid = xNotafis_oid
            Executor.Chave = xChave

            rsTabela = Nothing

            'IMPRIMIR A DATASHEET(ESTEIRA) E GUIA DE MONITORAÇÃO
            rsTabela = Executor.EmitirNotaDataSheet()

            Documento = ""

            i = 0
            For Each Texto In rsTabela.Tables(0).Rows
                Documento = Documento & rsTabela.Tables(0).Rows(i).Item(0).ToString() & vbCrLf
                i = i + 1
            Next


            If Documento <> "" Then
                Dim ArquivoDeclaracao As System.IO.File
                ArquivoDeclaracao.WriteAllText(CaminhoGravarTxt & xChave & "D.txt", Documento, Formato)
                Threading.Thread.Sleep(100)
                'FileCopy(CaminhoGravarTxt & xChave & "D.txt", ImpressoraEsteira)
                System.IO.File.Copy(CaminhoGravarTxt & xChave & "D.txt", ImpressoraEsteira)
            End If
            'Finaliza geração de datasheet

            Executor.Chave = xChave

            rsTabela = Nothing

            'IMPRIMIR A GUIA DE MONITORAÇÃO
            rsTabela = Executor.EmitirGuia

            Documento = ""

            i = 0
            For Each Texto In rsTabela.Tables(0).Rows
                Documento = Documento & rsTabela.Tables(0).Rows(i).Item("texto").ToString() & vbCrLf
                i = i + 1
            Next

            'IMPRIMIR A GUIA DE MONITORAÇÃO
            'If Documento <> "" Then
            '    Dim ArquivoDeclaracao As System.IO.File
            '    ArquivoDeclaracao.WriteAllText(CaminhoGravarTxt & xChave & "G.txt", Documento, Formato)
            '    Threading.Thread.Sleep(100)
            '    If rsTabela.Tables(0).Rows(1).Item(1).ToString() <> "" Then
            '        Select Case Trim(rsTabela.Tables(1).Rows(0).Item(0).ToString())
            '            Case "BND"
            '                System.IO.File.Copy(CaminhoGravarTxt & xChave & "G.txt", ImpressoraBND)
            '            Case "REM"
            '                System.IO.File.Copy(CaminhoGravarTxt & xChave & "G.txt", ImpressoraREM)
            '            Case "AMB"
            '                System.IO.File.Copy(CaminhoGravarTxt & xChave & "G.txt", ImpressoraREM)
            '            Case "HVL"
            '                System.IO.File.Copy(CaminhoGravarTxt & xChave & "G.txt", ImpressoraHVL)
            '            Case Else
            '                System.IO.File.Copy(CaminhoGravarTxt & xChave & "G.txt", ImpressoraCR)
            '        End Select
            '    End If
            'End If
            'Finaliza geração da declaração (guia de monitoração)


            rsTabela = Nothing

            'GRAVA A INFORMAÇÃO DE QUE A NOTA FISCAL FOI IMPRESSA

            Executor.P110fisc = xP110fisc
            Executor.P110id = xP110id
            rsTabela = Executor.GravaNotaEmitida

            'FIM DE INSTRUÇÃO ---A INFORMAÇÃO DE QUE A NOTA FISCAL FOI IMPRESSA JÁ FOI GRAVADA

            lblMensagem.Visible = True
            lblMensagem.BackColor = Color.White
            lblMensagem.Text = "EMBALADO MONITORADO COM SUCESSO! TAXA APRESENTADA: " & CStr(xTaxaSuperficie)
            btnFecharMensagem.Visible = True

            rsTabela = Nothing

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Call Limpar()

        End Try
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Call Confirmar()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Call Limpar()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtSuperficie_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuperficie.GotFocus

        If txtLote.Text = "" Then
            txtLote.Focus()
            Exit Sub
        End If

        If Trim(txtLote.Text) = Trim(txtSuperficie.Text) Then txtSuperficie.Text = ""

        txtSuperficie.BackColor = Color.LightBlue

    End Sub

    Private Sub txtSuperficie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuperficie.KeyDown
        If e.KeyCode = 13 Then
            If Trim(txtSuperficie.Text) = "" Then
                Exit Sub
            Else
                btnConfirmar.Focus()
            End If
        End If
    End Sub

    Private Sub txtSuperficie_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuperficie.LostFocus
        Dim xNumero As New MONITORACAO_EMBALADO.BaseControl

        txtSuperficie.BackColor = Color.White
        If Trim(txtSuperficie.Text) = "" Then
            btnConfirmar.Visible = False
            Exit Sub
        Else
            btnConfirmar.Visible = True
        End If

        If xNumero.NumeroInteiro(Trim(txtSuperficie.Text)) = False Then
            MsgBox("PREENCHA UM NÚMERO VÁLIDO!", MsgBoxStyle.Exclamation)
            txtSuperficie.Text = ""
            txtSuperficie.Focus()
            Exit Sub
        Else

            If CInt(txtSuperficie.Text) >= 500 And Etiqueta < 3 Then
                lblMensagem.BackColor = Color.Red
                lblMensagem.Visible = True
                lblMensagem.Text = "VERIFIQUE O TIPO DE ETIQUETA NO EMBALADO! A DOCUMENTAÇÃO SERÁ EMITIDA COM ETIQUETA 'AMARELO RADIOATIVO III' PARA ESTA TAXA DE DOSE NA SUPERFÍCIE!"
                btnFecharMensagem.Visible = True
                txtSuperficie.Text = ""
                txtSuperficie.Focus()
                Exit Sub
            Else
                'lblMensagem.Visible = False
                'lblMensagem.Text = ""
                'btnFecharMensagem.Visible = False
            End If

            txtMetro.Text = CInt(txtSuperficie.Text) / 10

            btnConfirmar.Focus()
        End If

    End Sub

    Private Sub btnConfirmar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmar.GotFocus
        If Trim(txtSuperficie.Text) = "" And Trim(txtLote.Text) <> "" Then
            MsgBox("PREENCHA OS DADOS DE DOSE NA SUPERFÍCIE!", MsgBoxStyle.Exclamation)
            txtSuperficie.Focus()
        Else
            btnConfirmar.Focus()
            btnConfirmar.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnConfirmar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmar.LostFocus
        btnConfirmar.BackColor = Color.LightCoral
    End Sub

    Private Sub txtLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLote.KeyDown
        If e.KeyCode = 13 Then
            txtSuperficie.Focus()
        End If
    End Sub

    Private Sub txtLote_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLote.GotFocus
        txtLote.BackColor = Color.LightBlue
    End Sub

    Private Sub btnFecharMensagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFecharMensagem.Click
        lblMensagem.BackColor = Color.White
        lblMensagem.Text = ""
        lblMensagem.Visible = False
        btnFecharMensagem.Visible = False
    End Sub

    Private Sub btnResetSonda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetSonda.Click
        StopProg(CSPCom_Renamed)
        CSPCom_Renamed = Initialize()
        'SI.Enabled = True
        'US.Enabled = True
    End Sub

    Private Sub AbrirSonda()
        Dim CodeName As Integer
        'UPGRADE_NOTE: Name was upgraded to Name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Name_Renamed As String
        If Checking(InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100)) Then
            'SI.Enabled = True
            'US.Enabled = True
            If Checking(GetProbeCode(CSPCom_Renamed, CodeName)) Then
                Name_Renamed = NameDisplay(CodeName)
                Checking(GetCurrentParam(CSPCom_Renamed, CSPParam))
            End If
        End If
        CloseComm(CSPCom_Renamed)

    End Sub

    Private Sub Monitorar()
        If ReadCount Then
            Timer1.Enabled = False
            Checking(CloseComm(CSPCom_Renamed))
            ReadCount = False
            QuantidadeLeituras = 0
        Else
            Checking(InitComm(CSPCom_Renamed, Common, CStr(PortaCom), 9600, 1000, 100))
            Timer1.Enabled = True
            ReadCount = True
            QuantidadeLeituras = 0
            SomaTotalValores = 0
            MaiorValor = 0
            lstValores.Items.Clear()
        End If
    End Sub

    Private Sub txtLote_TextChanged(sender As Object, e As EventArgs) Handles txtLote.TextChanged

    End Sub
End Class