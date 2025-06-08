Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic

Module CSPCom
	
	'///////////////////////////////////////////////////////////////
	'//
	'//     Module pour l'intégration de la dll CSPCom dans Visual Basic
	'//
	'//     La dll doit être placée dans WINDOWS\system32 ou dans le répertoire courant
	'//     Pour tout autre choix de répertoire, il faut changer la déclaration de la fonction
	'//
	'///////////////////////////////////////////////////////////////
	
	' ////////////////////////////////////////////////////////////
	' //              Déclaration de variables                  //
	' ////////////////////////////////////////////////////////////
	
	'Partie commune de la trame
	Public Structure Header
		Dim ClientAdr As Byte
		Dim Master As Integer
		Dim Emis As Integer
		Dim Recu As Integer
		Dim Status As Integer
	End Structure
	
	'Structure d'initialisation de la communication
	Public Structure CSPInit
		Dim Port As String
		Dim Baud As Integer
		Dim Tmo1 As Integer
		Dim Tmos As Integer
	End Structure
	
	'Structure des paramètres Radiagem
	Public Structure Param_Fonc
		Dim UnitCode As Integer
		Dim DataLogIdx As Short
		Dim Coeff1 As Single
		Dim Index_1 As Byte
		Dim Seuil_1 As Single
		Dim Saturation_1 As Single
		Dim Surface As Single
		Dim Coeff2 As Single
		Dim Index_2 As Byte
		Dim Seuil_2 As Single
		Dim Saturation_2 As Single
		Dim BkgTime1 As Integer
		Dim BkgTime2 As Integer
		Dim PretimeDataLog As Byte
	End Structure
	
	'Structure des mesures électroniques
	Public Structure ELECMEAS
		Dim PowerSupply As Single
		Dim RefSupply As Single
		Dim Temperature As Single
		Dim HVSetupReal As Single
		Dim HVReal As Single
		Dim DiscriReal As Single
	End Structure
	
	'Structure de la date
	Public Structure DATE_TIME
		'UPGRADE_NOTE: Day was upgraded to Day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Day As Byte
		'UPGRADE_NOTE: Month was upgraded to Month_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Month As Byte
		'UPGRADE_NOTE: Year was upgraded to Year_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Year As Byte
		'UPGRADE_NOTE: Hour was upgraded to Hour_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Hour As Byte
		'UPGRADE_NOTE: Minute was upgraded to Minute_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Minute As Byte
		'UPGRADE_NOTE: Second was upgraded to Second_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Second As Byte
	End Structure
	
	'Structure de la tolérance admise sur la Haute Tension
	Public Structure HV_Tolerance
		Dim Value As Byte
		Dim Percent As Byte
	End Structure
	
	'Structure des paramètres configuré en "usine"
	Public Structure Factory
		Dim HTSetup As Short
		'UPGRADE_NOTE: HV_Tolerance was upgraded to HV_Tolerance_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim HV_Tolerance As HV_Tolerance
		Dim DiscriLoSetup As Short
		Dim DiscriHiSetup As Short
		Dim DiscriAlphaBeta As Byte
		Dim Saturation_1 As Single
		Dim Saturation_2 As Single
		Dim BkgTime_1 As Short
		Dim BkgTime_2 As Short
		Dim Gain As Byte
		Dim Mode As Integer
		Dim PTBHomolog As Byte
	End Structure
	
	'Structure d'identification de la sonde
	Public Structure Identif
		Dim CODE_NAME As Integer
		Dim Name As String
		Dim Address As Byte
		Dim Serial As Short
		Dim PROBE_TYPE As String
		Dim DetSize As Single
	End Structure
	
	'Structure des paramètres de calibration voie 1 et 2
	Public Structure CALIB_CHANNEL
		Dim Emitter As String
		Dim RefSource As String
		Dim DateTime As DATE_TIME
		Dim Number As Byte
		Dim CoeffUser As Single
	End Structure
	
	Public Structure CRIT_PARAM
		'UPGRADE_NOTE: Identif was upgraded to Identif_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Identif As Identif
		'UPGRADE_NOTE: Factory was upgraded to Factory_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Factory As Factory
        Dim CalibChannel() As CALIB_CHANNEL
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
        Public Sub Initialize()
            ReDim CalibChannel(1)
            'ReDim CalibChannel(1)
        End Sub
	End Structure
	' ////////////////////////////////////////////////////////////
	' //              Fonctions de la DLL
	' ////////////////////////////////////////////////////////////
	
	
    Public Declare Function Initialize Lib "CSPCom.dll" () As Integer
    'Public Declare Function StopProg Lib "C:\inetpub\wwwroot\Sonda\Code Interface VB\Projet1.NET\bin\CSPCom.dll" (ByVal Adresse As Integer) As Short
    Public Declare Function StopProg Lib "CSPCom.dll" (ByVal Adresse As Integer) As Short
	
	'définition du type d'enregistrement
    Public Declare Function SetLog Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef Name As String, ByVal LogType As Integer) As Short
	
	'ouverture fermeture du port
	'UPGRADE_WARNING: Structure Header may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function InitComm Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef Common As Header, ByVal Port As String, ByVal Baud As Integer, ByVal Tmo1 As Integer, ByVal tmo2 As Integer) As Short
    Public Declare Function CloseComm Lib "CSPCom.dll" (ByVal Adresse As Integer) As Short
	
	'requêtes de lecture d'informations
	Public Declare Function GetAlrmLvlArray Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pData As Single, ByVal CodeUnit As Integer, ByVal IndexSeuil As Short) As Short
	Public Declare Function GetAlrmLvlIndexArray Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pData As Byte, ByVal Channel As Integer, ByVal CodeUnit As Integer) As Short
	'UPGRADE_WARNING: Structure CRIT_PARAM may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function GetCriticalParameter Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef CriticalParam As CRIT_PARAM) As Short
	Public Declare Function GetCount Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pCount1 As Integer, ByRef pCount2 As Integer) As Short
	'UPGRADE_WARNING: Structure ELECMEAS may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Public Declare Function GetElectroMeas Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pElectroMeas As ELECMEAS, ByRef Mode As String) As Short
	Public Declare Function GetProbeCode Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pCodeName As Integer) As Short
	'UPGRADE_WARNING: Structure Param_Fonc may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Public Declare Function GetCurrentParam Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pParamPrb As Param_Fonc) As Short
	Public Declare Function GetSerialNum Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pNumSerial As Short) As Short
	'UPGRADE_NOTE: system was upgraded to system_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Declare Function GetUnitArray Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pUnit As Byte, ByVal system_Renamed As Integer, ByVal numPosition As Integer) As Short
	Public Declare Function GetVersion Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pVersion As Byte) As Short
    'Public Declare Function GetCriticalParameter Lib "C:\inetpub\wwwroot\Sonda\Code Interface VB\Projet1.NET\bin\CSPCom.dll" (ByVal Adresse As Integer, ByRef CriticalParam As CRIT_PARAM) As Short

	'requêtes d'écriture d'informations
	Public Declare Function SetAlrmLvlArray Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pData As Single, ByVal CodeUnit As Integer, ByVal IndexSeuil As Short) As Short
	Public Declare Function SetAlrmLvlIndexArray Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pData As Byte, ByVal Channel As Integer, ByVal CodeUnit As Integer) As Short
	Public Declare Function SetUnit Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef pUnitData As Integer) As Short
	Public Declare Function SaveData Lib "CSPCom.dll" (ByVal Adresse As Integer, ByVal DataType As String, ByVal Data As String) As Short
	
	'les accesseurs
	Public Declare Function IsErrName Lib "CSPCom.dll" (ByVal Adresse As Integer) As Short
	Public Declare Sub SetErrName Lib "CSPCom.dll" (ByVal Adresse As Integer, ByVal noErr As Short)
	
	' pour récupérer la dernière erreur numéro et message
    Public Declare Function GetLastError Lib "CSPCom.dll" (ByVal Adresse As Integer) As Short
    Public Declare Sub GetLastErrorMsg Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef Chaine As String)
	
	' pour récupérer l'état de la communication
	Public Declare Function GetCommInit Lib "CSPCom.dll" (ByVal Adresse As Integer) As Short
	
	' pour récupérer le nom d'enregistrement
	Public Declare Sub GetLogName Lib "CSPCom.dll" (ByVal Adresse As Integer, ByRef Chaine As String)
	
	Public Declare Sub GetPortName Lib "CSPCom.dll" (ByRef Port As String, ByVal AddrIdx As Integer)
	
	
	' ////////////////////////////////////////////////////////////
	' //              Fonctions traduisant certains codes
	' ////////////////////////////////////////////////////////////
	
	' Fonction traduisant le code des unités
	Private Function UnitDisplay(ByRef UnitCode As Integer) As String
		Dim Units(21) As String
		Dim l As Integer
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
	End Function
	
	' Fonction traduisant le code des noms de sonde
	Private Function NameDisplay(ByRef CodeName As Integer) As String
		'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NameDisplay = VB.Switch(CodeName = 129, "CSP Alpha", CodeName = 130, "CSP Beta", CodeName = 132, "CSP Gamma", CodeName = 144, "CSP X", CodeName = 160, "CSP Spectro", CodeName = 193, "CSP Alpha+Beta Mixte")
	End Function
	
	' Fonction traduisant le code des types de sonde
	Private Function TypeDisplay(ByRef CodeName As Integer) As String
		'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TypeDisplay = VB.Switch(CodeName = 0, "Gamma", CodeName = 1, "Alpha", CodeName = 2, "Beta", CodeName = 3, "Alpha+Beta", CodeName = 4, "Alpha+Beta+Gamma", CodeName = 5, "Neutron", CodeName = 6, "Neutron+Gamma", CodeName = 7, "X")
	End Function
	
	' Fonction traduisant le code des modes de fonctionnements
	Private Function ModeDisplay(ByRef CodeMode As Integer) As String
		'UPGRADE_WARNING: Couldn't resolve default property of object Switch(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ModeDisplay = VB.Switch(CodeMode = 0, "", CodeMode = 1, "Mode Alpha", CodeMode = 2, "Mode Beta", CodeMode = 3, "Mode Alpha+Beta", CodeMode = 4, "Discriminateur en énergie", CodeMode = 8, "Générateur test interne", CodeMode = 16, "Comptage Net", CodeMode = 32, "Led")
	End Function
End Module