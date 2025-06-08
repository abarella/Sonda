//////////////////////////////////////////////////////////////////////////////
//
//  Creation 09/05/2006							Auteur : Andry Rabemanantsoa
//
//								C S P C o m . H
//
//  Version 0.12								Dernière Revision : 27/06/2006
//
//----------------------------------------------------------------------------
//
//	Fichier entête de la DLL CSPCom.dll
//
//	Historique des versions:
//	Version 0.01	implémentation des fonctions de RdPrbCom.c dans la classe
//	Version 0.02	(10/05/2006)	Linkage vers les fonctions de RdPrbCom.
//	Version 0.03	(12/05/2006)	Version gérant les exportations.
//	Version 0.04	(16/05/2006)	Ajout des messages d'erreurs.
//	Version 0.05	(18/05/2006)	Mise en oeuvre de la fonction
//															d'enregistrement
//	Version 0.06	(30/05/2006)	Ajout de la date
//									Changement des paramètres
//												pour la sauvegarde des données
//	Version 0.07	(31/05/2006)	Ajout d'une fonction pour sortir les
//										paramètres vitaux sous forme de structure
//	Version 0.08	(02/06/2006)	Ajout d'une fonction privée changeant la
//											définition du mode de fonctionnement
//	Version	0.09	(08/06/2006)	Changement de GetElectroMeas pour renvoyer
//										 les valeurs réelles ainsi que le mode
//									Changement de la structure en paramètres
//															de GetCriticalParam
//	Version 0.10	(09/06/2006)	Changement de GetVersion en une fonction
//																à 1 paramètre
//	Version 0.11	(14/06/2006)	Enlèvement des fonctions GetDataLog et ResetSoftProbe
//									Ajout des structures nécessaires au fonctionnement
//									de la dll	
//	Version 0.12	(27/06/2006)	Modification de la fonction SaveData
//----------------------------------------------------------------------------

#if !defined(AFX_CSPCOM_H__61FE7281_1E80_4360_96DA_32FA999EE42C__INCLUDED_)
#define AFX_CSPCOM_H__61FE7281_1E80_4360_96DA_32FA999EE42C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include <time.h>
#include "Oaidl.h"

#define MAX_LEN_WRITE_ALRM_LVL		10
#define	NB_TRY_COMM					3
#define DELAY_BETWEEN_RETRY_COMM	100
#define DELAY_BETWEEN_RESET			200

//----------------------------------------------------------------------------
//
//					Partie DLL
//
//----------------------------------------------------------------------------
#ifdef CSPCOM_EXPORTS						//si on exporte les fonctions

#include "CSPProbe.h"						//on récupère les structures dans ces fichiers

#define CSPCOM_DLL __declspec(dllexport)	//on définit CSPCOM_DLL pour l'exportation

#else

#define CSPCOM_DLL __declspec(dllimport)	//on définit CSPCOM_DLL pour l'importation

//on récupère les structures ici:

//////////////////////////////////////////////////////////////////////////////
//
//	Structures utilisables par l'utilisateur
//
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------



//////////////////////////////////////////////////////////////////////////////
//
// Definition des codes d'erreur retournes par les fonctions du SDK.
//
//----------------------------------------------------------------------------

	typedef	enum
			{						//------------------------------------------------
			RDPRB_ERR_NONE,			// Aucune erreur								--
									//------------------------------------------------
									
									//------------------------------------------------
									// Codes d'erreur provenant de la sonde SLAVE	
									//------------------------------------------------
			RDPRB_ERR_SL_NONE=0,	// SLAVE ne signale aucune erreur				
			RDPRB_ERR_SL_COMMAND,	// SLAVE dit qu'il ne comprend pas le commande	
			RDPRB_ERR_SL_LENGTH,	// SLAVE signale une trame de longueur incorrecte
			RDPRB_ERR_SL_MODE,		// SLAVE refuse le mode d'ouverture du fichier	
			RDPRB_ERR_SL_NO_HANDLE,	// SLAVE n'a plus de handle de fichier disponible
			RDPRB_ERR_SL_DIR,		// SLAVE signale erreur de lecture du repertoire
			RDPRB_ERR_SL_OPEN,		// SLAVE signale une erreur d'ouverture du fichier
			RDPRB_ERR_SL_HANDLE,	// SLAVE dit que le handle de fichier est incorrect
			RDPRB_ERR_SL_ARG,		// SLAVE signale un argument incorrect			
			RDPRB_ERR_SL_HISTO,		// SLAVE signale une erreur d'acces a l'historique
			RDPRB_ERR_SL_ELEMENT,	// SLAVE dit que le numero d'element est incorrect
			RDPRB_ERR_SL_ACTION,	// SLAVE dit que l'element ne connait pas l'action
			RDPRB_ERR_SL_SONDE,		// SLAVE dit que le numero de sonde est incorrect
			RDPRB_ERR_SL_SOMME,		// SLAVE dit que le numero de somme est incorrect
			RDPRB_ERR_SL_LIMITED,	// SLAVE refuse cette requete en mode degrade	
			RDPRB_ERR_SL_LINK,		// SLAVE signale un defaut de liaison avec la sonde
			RDPRB_ERR_SL_EXEC,		// SLAVE ne peut pas executer la commande
			RDPRB_ERR_SL_TYPE,		// SLAVE qui répond n'est pas celui questionné
			RDPRB_ERR_SL_ANSWER,	// la réponse du SLAVE ne m'est pas destinée
			RDPRB_ERR_SL_ADRESS,	// SLAVE qui répond n'a pas l'adresse de celui questionné
									//------------------------------------------------
			RDPRB_ERR_SL_CARD,		// Cardinal de l'ensemble des erreurs du SLAVE	
									//------------------------------------------------
	
									//------------------------------------------------
									// Erreurs provenant du protocole Stx/Etx		
									//------------------------------------------------
			RDPRB_ERR_STX			// StxEtx signale une erreur inconnue			
			= RDPRB_ERR_SL_CARD,	//												
			RDPRB_ERR_STXEXEC,		// StxEtx ne peut pas executer la demande		
			RDPRB_ERR_TIMEOUT,		// StxEtx signale un time-out en reception		
			RDPRB_ERR_LINE,			// StxEtx signale une erreur sur la ligne		
			RDPRB_ERR_TOO_LONG,		// StxEtx signale une trame trop longue			
			RDPRB_ERR_NOT_HEXA,		// StxEtx signale un caractere non hexadecimal	
			RDPRB_ERR_CODING,		// StxEtx signale que la trame est mal codee	
									//------------------------------------------------
									
									//------------------------------------------------
									// Erreurs provenant du protocole 			
									//------------------------------------------------
			RDPRB_ERR_PREPARE,		// Erreur lors de la preparation de la commande	
			RDPRB_ERR_SEND,			// StxEtx signale une erreur en emission		
			RDPRB_ERR_TOO_SHORT,	// La trame recue est trop courte				
			RDPRB_ERR_FCS,			// Le FCS du datagram recu est incorrect		
			RDPRB_ERR_ID,			// La reponse ne provient pas du SLAVE interroge
			RDPRB_ERR_FUNCTION,		// Le code fonction de la reponse est incoherent
			RDPRB_ERR_ANALYSIS,		// Les donnees du datagram recu sont incorrectes
									//------------------------------------------------
									
									//------------------------------------------------
									// Erreurs provenant du SDK lui-meme			
									//------------------------------------------------
			RDPRB_ERR_ARG,			// Arguments d'appel incorrects					
			RDPRB_ERR_MEM,			// Memoire insuffisante							
			RDPRB_ERR_EXEC,			// Execution impossible							
			RDPRB_ERR_LINK,			// Liaison indisponible							
									//------------------------------------------------
									
									//------------------------------------------------
			RDPRB_ERR_CARD			// Cardinal de l'ensemble des codes d'erreur	
			}						//------------------------------------------------
			RDPRB_ERR ;

//----------------------------------------------------------------------------
//	structure de la date et l'heure échangées dans les trames
//----------------------------------------------------------------------------

	typedef struct	
			{	
				BYTE	Day;
				BYTE	Month;
				BYTE	Year;
				BYTE	Hour;
				BYTE	Minute;
				BYTE	Second;
			} RDPRB_DATE_TIME;

//----------------------------------------------------------------------------
//	Définition des codes de l'octet Mode de la trame paramètre
//----------------------------------------------------------------------------

	typedef	enum
			{
				RDPRB_MODE_ALPHA			= 0x01,		// alpha
				RDPRB_MODE_BETA				= 0x02,		// bêta
				RDPRB_MODE_GAMMA_DISCRI_HI	= 0x04,		// gamma seuil dicriminateur haut
				RDPRB_MODE_GENE_ON			= 0x08,		// générateur test interne ON
				RDPRB_MODE_COUNT_NET		= 0x10,		// comptage Net
				RDPRB_MODE_LED_ON			= 0x20,		// Led ON
	
				RDPRB_MODE_CARD
			} RDPRB_CODE_MODE;

//----------------------------------------------------------------------------
//	Les positions possibles des sondes mixtes
//----------------------------------------------------------------------------

	typedef	enum
			{
				MIXTE_POS_0,
				MIXTE_POS_1,
				MIXTE_POS_2,

				MIXTE_POS_CARD		// 3 positions
			} RDPRB_MIXTE_POS;

//----------------------------------------------------------------------------
//		Définition des codes Noms
//----------------------------------------------------------------------------

	typedef	enum
			{
				RDPRB_NAME_PC,
				RDPRB_NAME_RADIAGEM,
				RDPRB_NAME_MIXTE	 = 0x40,	// Mixte Probe
				RDPRB_NAME_SA		 = 0x81, // Sonde Alpha
				RDPRB_NAME_SB		 = 0x82,	// Sonde Beta
				RDPRB_NAME_SAB		 = 0x83,	// Sonde Alpha + Beta non mixte
				RDPRB_NAME_SG		 = 0x84, // Sonde Gamma
				RDPRB_NAME_SABG		 = 0x87,	// Sonde Alpha + Beta + Gamma non mixte
				RDPRB_NAME_SN		 = 0x88, // Sonde Neutron
				RDPRB_NAME_SX		 = 0x90, // Sonde X
				RDPRB_NAME_SPECTRO	 = 0xA0, // Sonde specto
				RDPRB_NAME_SA_MIXT	 = 0xC1, // Sonde mixte position Alpha
				RDPRB_NAME_SB_MIXT	 = 0xC2,	// Sonde mixte position Beta
				RDPRB_NAME_SAB_MIXT	 = 0xC3,	// Sonde mixte position Alpha + Beta
	
				RDPRB_NAME_BROADCAST = 0xFF, // mode broadcast

				RDPRB_NAME_CARD
			} RDPRB_CODE_NAME;

//----------------------------------------------------------------------------
//		Définition des codes status
//----------------------------------------------------------------------------

	typedef	enum
			{
				RDPRB_STATUS_OK				= 0x0000,	// aucun problème à signaler
				RDPRB_STATUS_HS				= 0x0001,	// Hors service
				RDPRB_STATUS_SAT_CPT		= 0x0002,	// Count saturation
				RDPRB_STATUS_WRI_ERR		= 0x0004,	// Memory Write error
				RDPRB_STATUS_REC_ERR		= 0x0008,	// Trame received error
				RDPRB_STATUS_POWER_SUPPLY	= 0x0010,	// power supply fault
				RDPRB_STATUS_HIGH_VOLTAGE	= 0x0020,	// high voltage fault
				RDPRB_STATUS_MEMORY			= 0x0040,	// FRAM checksum fault
				RDPRB_STATUS_INIT			= 0x0080,	// Init in progress
				RDPRB_STATUS_PTB_DDD		= 0x0100,	// PTB Homologation dose rate, max dose and contamination
				RDPRB_STATUS_PTB_INTEG		= 0x0200,	// PTB Homologation dose integration
				RDPRB_STATUS_PTB_DATA_LOG	= 0x0400,	// PTB Homologation data logging
				RDPRB_STATUS_SERVICE_MODE	= 0x4000,	// From PC - Service mode
				RDPRB_STATUS_TEST_ALPHA		= 0x4000,	// Indique que la sonde est en cours de test détecteur Alpha
				RDPRB_STATUS_UNADJUST		= 0x8000,	// probe unadjusted
	
				RDPRB_STATUS_CARD
			} RDPRB_CODE_STATUS;



//----------------------------------------------------------------------------
//	Structure des données communes à toutes les trames qui doivent être 
//	communiquées par l'appelant
//----------------------------------------------------------------------------

	typedef struct
			{ 
				BYTE ClientAdr;					// l'adresse du client sur le réseau
				RDPRB_CODE_NAME	  NameMaster;	// le nom du maitre du dialogue (ici le PC)
				RDPRB_CODE_NAME	  NameSondeEmis;// le nom de la sonde à qui l'on s'adresse
				RDPRB_CODE_NAME	  NameSondeRecu;// le nom de la sonde qui répond
				RDPRB_CODE_STATUS Status;		// le status de l'émetteur, toujours celui 
												// du PC aujourd'hui, mais à l'avenir ?
				BYTE CSPComSN [3];
			} RDPRB_COMMON_HEADER;

//----------------------------------------------------------------------------
//	Définition des codes de l'octet Unit de la trame paramètre (code 0x0A)
//----------------------------------------------------------------------------

	typedef	enum
			{
				RDPRB_UNIT_CONTA_SI_cps,			//	S.I. c/s alpha ou béta 
				RDPRB_UNIT_CONTA_US_CPM,			//	U.S.A CPM alpha ou béta
				RDPRB_UNIT_CONTA_SI_BQ_EQ,			//	S.I. Bq eq alpha ou béta 
				RDPRB_UNIT_CONTA_US_DPM_EQ,			//	U.S.A DPM eq alpha ou béta
				RDPRB_UNIT_CONTA_SI_BQ_EQpcm2,		//	S.I. Bq eq/cm² alpha ou béta 
				RDPRB_UNIT_CONTA_US_DPM_EQp100cm2,	//	U.S.A DPM eq/100cm² alpha ou béta
				RDPRB_UNIT_CONTA_CARD = RDPRB_UNIT_CONTA_US_DPM_EQp100cm2,	//	Fin des unités CONTA
	
				RDPRB_UNIT_GAMMA_SI_cps,			//	S.I. c/s gamma 
				RDPRB_UNIT_GAMMA_US_CPS,			//	U.S.A CPS gamma
				RDPRB_UNIT_GAMMA_SI_Sv_EQ,			//	S.I. Sv eq gamma 
				RDPRB_UNIT_GAMMA_US_R,				//	U.S.A R (Randgun) gamma
				RDPRB_UNIT_GAMMA_SI_Sv_EQpH,		//	S.I. Sv eq/h gamma 
				RDPRB_UNIT_GAMMA_US_RpH,			//	U.S.A R/h gamma
				RDPRB_UNIT_GAMMA_CARD = RDPRB_UNIT_GAMMA_US_RpH,			//	Fin des unités GAMMA
	
				RDPRB_UNIT_GAMMA_SI_Sv,				//	S.I. Sv gamma 
				RDPRB_UNIT_GAMMA_US_rem,			//	U.S.A rem gamma
				RDPRB_UNIT_GAMMA_SI_SvpH,			//	S.I. Sv/h gamma 
				RDPRB_UNIT_GAMMA_US_rempH,			//	U.S.A rem/h gamma
				RDPRB_UNIT_SPECTRE_SI_Sv,			//	S.I. Sv (avec le spectre) 
				RDPRB_UNIT_SPECTRE_US_rem,			//	U.S.A rem (avec le spectre) 
				RDPRB_UNIT_SPECTRE_SI_SvpH,			//	S.I. Sv/h (avec le spectre) 
				RDPRB_UNIT_SPECTRE_US_rempH,		//	U.S.A rem/h (avec le spectre) 
	
				RDPRB_UNIT_CONTA_ALPHABETA_SI_cps,	//	S.I. c/s alpha ET béta 
				RDPRB_UNIT_CONTA_ALPHABETA_US_CPM,	//	U.S.A CPM alpha ET béta
	
				RDPRB_UNIT_CARD
			} RDPRB_CODE_UNIT;

//----------------------------------------------------------------------------
//	structure pour récupérer les données de comptage 16 bits (corrigé ou non) :
//		les voies de comptage 1 et 2
//----------------------------------------------------------------------------

	typedef struct
			{
				BOOL	Corrected;	// TRUE = comptage corrigé, FALSE = comptage
				WORD	Count_1;	// Voie de comptage Béta
				WORD	Count_2;	// Voie de comptage Gamma ou Alpha
			} RDPRB_DATA_COUNT;


//----------------------------------------------------------------------------
//	structure pour récupérer les données de comptage (corrigé ou non) :
//		les voies de comptage 1 et 2
//----------------------------------------------------------------------------

	typedef struct
			{
				BOOL	Corrected;	// TRUE = comptage corrigé, FALSE = comptage
				float	ExtCount_1;	// Voie de comptage Béta
				float	ExtCount_2;	// Voie de comptage Gamma ou Alpha
			} RDPRB_DATA_EXT_COUNT;

//----------------------------------------------------------------------------
//	structure pour récupérer la réponse à la demande de mesure en mode réseau
//----------------------------------------------------------------------------
typedef struct
		{
			BOOL	Corrected;	// TRUE = comptage corrigé, FALSE = comptage
			long	TimeElapsed;	// Temps écoulé
			float	Count_1;	// Comptage cumulé ou débit moyenné voie 1
			float	CountMaxi_1;	// Comptage maxi ou débit maxi voie 1
			float	Count_2;	// Comptage cumulé ou débit moyenné voie 2
			float	CountMaxi_2;	// Comptage maxi ou débit maxi voie 2
		} RDPRB_RESEAU_COUNT;

//----------------------------------------------------------------------------
//	structure pour récupérer les paramètres réseau
//----------------------------------------------------------------------------
typedef struct
		{
			BYTE	NetworkNumber;	//Network number
			BYTE	RepSupSN1;		//Octet1 du numéro de série du répéteur/superviseur
			BYTE	RepSupSN2;		//Octet2 du numéro de série
			BYTE	RepSupSN3;		//Octet3 du numéro de série
			BYTE	DeviceType;		//Type de device (0=répéteur, 1=superviseur)
		} RDPRB_NETWORK_PARAM;

//----------------------------------------------------------------------------
//	structure pour récupérer les mesures avec un CSP Com RF
//----------------------------------------------------------------------------
typedef struct
		{
			BYTE	CSPSerial1;
			BYTE	CSPSerial2;
			BYTE	CSPSerial3;
			BYTE	ProbeStatus1;
			BYTE	ProbeStatus2;
			long	TimeElapsed;
			float	Count_1;
			float	MaxCount_1;
			float	Count_2;
			float	MaxCount_2;
		}RDPRB_RF_COUNT;

//----------------------------------------------------------------------------
//	structure pour récupérer les données de débit de dose instantanné et lissé
//	d'une voie de comptage
//----------------------------------------------------------------------------

typedef struct
		{
			float	DoseRateSnap;	// débit de dose instantanné
			float	DoseRateSmooth;	// débit de dose lissé
		} RDPRB_DATA_CHANNEL_DDD;


//----------------------------------------------------------------------------
//	structure pour récupérer les données de dose intégrées de 2 voies de 
//	comptage et le temps d'intégration
//----------------------------------------------------------------------------

typedef struct
		{
			float	IntegratedDose_1;	// dose intégrée voie 1
			float	IntegratedDose_2;	// dose intégrée voie 2
			long	lIntegTime;			// temps d'intégration (long!)(LSB = 10 ms)
		} RDPRB_DATA_INTEG_DOSE;


//----------------------------------------------------------------------------
//	structure pour récupérer les données de débit de dose instantanné et lissé
//	la dose intégrée et le temps d'intégration des deux voies de comptage
//----------------------------------------------------------------------------

typedef struct
		{
			RDPRB_DATA_CHANNEL_DDD	DoseRate_1;	// débit de dose voie 1
			RDPRB_DATA_CHANNEL_DDD	DoseRate_2;	// débit de dose voie 2
			RDPRB_DATA_INTEG_DOSE	IntegDose;	// dose intégrée voies 1 et 2
			WORD					wIntegTime;	// temps d'intégration (WORD!)(LSB = 10 ms)
		} RDPRB_DATA_DDD;


//----------------------------------------------------------------------------
//	structure pour récupérer les données des seuils d'alarmes courants :
//		les index et les valeurs des seuils d'alarme 
//----------------------------------------------------------------------------

	typedef struct
			{
				BYTE	IndexAlrm_1;	// index seuil d'alarme voie 1
				BYTE	IndexAlrm_2;	// index seuil d'alarme voie 2
				float	AlrmLvl_1;		// valeur du seuil d'alarme voie 1
				float	AlrmLvl_2;		// valeur du seuil d'alarme voie 2
			} RDPRB_DATA_ALRM_LVL;


//----------------------------------------------------------------------------
//	structure pour récupérer les données de l'unité de mesure courante :
//		l'index et les valeurs des Coeffs de conversion
//----------------------------------------------------------------------------

	typedef struct
			{
				RDPRB_CODE_UNIT			Unit;	 // l'unité courante
				RDPRB_DATA_ALRM_LVL		AlrmLvl; // la structure des seuils d'alarme
			} RDPRB_DATA_UNIT;

//----------------------------------------------------------------------------
//	Structure des paramètres d'initialisation de CSPCom.dll
//----------------------------------------------------------------------------
	typedef struct
			{
				LPSTR	PortComm 			/*=	"COM1"	*/;
				long	VitesseTrans		/*=	9600	*/;
				long	FirstByteTimeout	/*=	1000	*/;
				long	OtherBytesTimeout	/*=	100		*/;
				long	IndexPortSelected;
			} CSPComInit;


//----------------------------------------------------------------------------
//	paramètres nécessaires au RADIAGEM
//----------------------------------------------------------------------------

	typedef struct	
			{
				RDPRB_CODE_UNIT			Unit;			// l'unité courante utilisée par la sonde
				WORD					IndexDataLog;	// l'index courant du Data logging
				float					Coeff1;			// coeff de conversion c/s en Bq ou linéarité c/s en débit (alpha ou gamma)
				BYTE					IndexSeuil1;	// index du seuil 1 (alpha ou gamma)
				float					Seuil1;			// seuil 1 (alpha ou gamma)
				float					Saturation1;	// saturation Radiagem ou PC (alpha ou gamma)
				float					Surface;		// Surface de détection
				float					Coeff2;			// coeff de conversion c/s en Bq ou linéarité c/s en débit (béta)
				BYTE					IndexSeuil2;	// index du seuil 2 (bêta)
				float					Seuil2;			// seuil 2 (bêta)
				float					Saturation2;	// saturation Radiagem ou PC (bêta)
				WORD					BkgTime1;		// temps de mesure du Bdf voie 1
				WORD					BkgTime2;		// temps de mesure du Bdf voie 2
				BYTE					PretimeDataLog;	// temps d'intégration pour le Data Logging
			} RDPRB_PARAM_FONC;

//----------------------------------------------------------------------------
//	structure des données du spectre
//----------------------------------------------------------------------------

typedef struct
		{
			WORD	Channel[256];
			WORD	TimeAcq;
			float	EnergCalib; 
		} SPECTRUM_DATA;

//----------------------------------------------------------------------------
//	Les voies de comptage
//----------------------------------------------------------------------------

typedef	enum
		{
			CHANNEL_1,
			CHANNEL_2,

			CHANNEL_CARD		// 2 voies de comptage dans une sonde
		} COUNT_CHANNEL;


//////////////////////////////////////////////////////////////////////////////
//
//			Structures relatives aux derniers firmwares
//
//----------------------------------------------------------------------------
namespace CSPProbe
{
//----------------------------------------------------------------------------
//	Deux systèmes d'unités coexistent actuellement dans le monde : 
//		- le système approuvé par la plupart des pays : le Système Internationnal (SI)
//		- le système utilisé par les USA : le Système USA (USA)
//
//	chaque sonde contient donc	: deux tableaux d'unités un SI et un USA
//								: un index d'unité courante pour chaque tableau soit 2 index
//
//	Les types d'unité possible
//----------------------------------------------------------------------------

	typedef	enum
			{
				UNIT_SYSTEM_SI,	// système d'Unités Internationnal (SI)
				UNIT_SYSTEM_US,	// système d'unités spécifique aux USA

				UNIT_SYSTEM_CARD	// 2 systèmes d'unités
			} UNIT_SYSTEM_TYPE;


//----------------------------------------------------------------------------
//	valeurs des index max pour les tableaux de seuil d'alarme et de non linéarité
//----------------------------------------------------------------------------

	const int INDEX_MAX_ALRM_LVL	= 10;	// 10 seuils d'alarme max pour une unité

//----------------------------------------------------------------------------
//	structure contenant toutes les mesures électroniques d'une sonde
//----------------------------------------------------------------------------

	typedef struct
			{
				float		PowerSupply;	// mesure de la tension d'alimentation
				float		RefSupply;		// mesure de la tension de référence du codeur A/N
				float		Temperature;	// mesure de la température interne de la sonde
				float		HvSetupReal;	// mesure de la consigne de Haute Tension réellement demandée
				float		HvReal;			// mesure de la Haute Tension réellement appliquée sur le détecteur
				float		DiscriReal;		// mesure de la tension réelle du discriminateur
			} ELECTRONIC;

//----------------------------------------------------------------------------
//	structure des unités d'une sonde
//----------------------------------------------------------------------------

	typedef struct
			{
				BYTE					Value;		// la valeur qui sera écrite dans la sonde
				BYTE					Percent;	// le pourcentage à affiché et permettant le calcul de la valeur
			} HV_TOLERANCE;

//----------------------------------------------------------------------------
//	structure des paramètres de fabrication (électronique) de la sonde
//----------------------------------------------------------------------------

	typedef struct
	{
		WORD				HTSetup;		// consigne HT en V
		HV_TOLERANCE		HTTolerance;	// tolérance admise sur la HT
		WORD				DiscriLoSetup;	// consigne discri bas en mV
		WORD				DiscriHiSetup;	// consigne discri haut en mV
		BYTE				DiscriAlphaBeta;// valeur du potentiomètre discri alpha/béta
		float				Saturation_1;	// valeur de saturation voie 1
		float				Saturation_2;	// valeur de saturation voie 2
		WORD				BkgTime_1;		// temps pour le seuil bas Bdf voie 1
		WORD				BkgTime_2;		// temps pour le seuil bas Bdf voie 2
		BYTE				Gain;			// consigne gain (0x00 à 0x07)
		RDPRB_CODE_MODE		Mode;			// mode de fonctionnement
		BYTE				PTBHomolog;		// registre indiquant les homologations PTB (b0, b1 et b2) 0 = homologué
	} FACTORY;



}
#endif//CSPCOM_EXPORTS


using namespace CSPProbe;
//----------------------------------------------------------------------------

//---------------------Structures supplémentaires-----------------------------


//----------------------------------------------------------------------------
//	Enum des types de sauvegardes
//----------------------------------------------------------------------------

	typedef enum
	{
		NO_LOG,			//il n'y a aucune sauvegarde
		LOG_ERR,		//on sauvegarde les erreurs
		LOG_REQ,		//on établit un historique des requêtes et des erreurs
		LOG_COUNT,		//on enregistre les comptages
		LOG_ALL,		//on établit un historique des requêtes et on enregistre les comptages
		LOG_CARD		//cardinal des types de sauvegarde des données
	} LOG_TYPE;
	
//----------------------------------------------------------------------------
//	structure des paramètres de calibration pour une voie de mesure
//----------------------------------------------------------------------------

	typedef struct
	{
		LPSTR						Emitter;
		LPSTR						Source;
		RDPRB_DATE_TIME				DateTime;
		BYTE						Number;							// le numéro de la calibration
		float						CoeffUser;						// le coeff de conversion Bqeq/c/s ou Sveq/c/s selon la sonde
	} CALIB_DATA;

//----------------------------------------------------------------------------
//	structure d'identification de la sonde
//----------------------------------------------------------------------------
	
	typedef struct
	{
		RDPRB_CODE_NAME				CodeName;						// nom codé de la sonde
		LPSTR						Name;							// mode au démarrage pour une sonde mixte
		BYTE						Address;						// adresse de la sonde
		WORD						SerialNum;						// le numéro de série
		LPSTR						Type;							// Type de sonde (Gamma, Alpha, Béta, etc.)
		float						DetSize;						// la surface de détection ou la taille du détecteur
	} ID_DATA;												

//----------------------------------------------------------------------------
//	structure contenant tous les paramètres vitaux d'une sonde à sauvegarder 
//	dans la zone constructeur de la FRAM de la sonde
//----------------------------------------------------------------------------
	typedef struct
	{
		ID_DATA						Identif;						// Identification de la sonde
		FACTORY						Factory;						// paramètres configurés en "usine"
		CALIB_DATA					CalibChannel[CHANNEL_CARD];		// paramètres de calibration voie 1 et 2
	} CRIT_PARAM;

//----------------------------------------------------------------------------
//					C l a s s e		C C S P C o m
//
//----------------------------------------------------------------------------


class CSPCOM_DLL CCSPCom  
{
public:
					CCSPCom					( void );
	virtual			~CCSPCom				( void );
					
					
// redéfinir la sortie des fonctions
				
// Fonctions publiques de la DLL
				
	//	définition du type d'enregistrement
	// ------------------------------------
	bool			SetLog						( LPSTR * Name,						//	nom du fichier de sauvegarde
												  LOG_TYPE log_type					//	type de sauvegarde
												);										
	bool			SaveData					( LPSTR DataType,					// données 1
												  LPSTR Data = NULL					// données 2
												);
																						
	// ouverture fermeture du port													
	// ---------------------------													
	bool			InitComm					( RDPRB_COMMON_HEADER * pCommon ,	//	trame commune
												  LPSTR Port,						//	Port de communication sur lequel se trouve la sonde
												  long Baud = 9600,					//	Vitesse de transfert (fixe jusqu'à maintenant)
												  long Tmo1 = 1000,					//	Temps de réponse admissible pour le 1er octet
												  long Tmo2 = 100					//	Temps de réponse admissible pour les octets suivants
												);										
	bool			CloseComm					( void );								
																						
	// requêtes	de lecture d'informations											
	// ----------------------------------											
	bool			GetAlrmLvlArray				( 
												  float * pData,					//	tableau ou flottant recevant les seuils
												  RDPRB_CODE_UNIT CodeUnit,			//	unité des seuils d'alarme							//  communication directe à partir du cable USB
												  WORD IndexSeuil = 0				//	index du 1er seuil à récupérer
												);

	bool			GetAlrmLvlIndexArray		( 
												  BYTE * pData,						//	index du seuil d'alarme courant
												  COUNT_CHANNEL Channel,			//	voie de mesure
												  RDPRB_CODE_UNIT CodeUnit = (RDPRB_CODE_UNIT)0 //unité du seuil d'alarme courant
												) ;

	bool			GetCriticalParameter		( CRIT_PARAM * pCriticalParam);		//	structure recevant les paramètres vitaux
														
	bool			GetCount					( RDPRB_DATA_COUNT * pCount);		//	structure recevant les comptages 16 bits (WORD)
	
//CSP Com Ethernet, wifi, bluetooth, RS485 et RF
	bool			StartReseau					( RDPRB_RESEAU_COUNT * pCountReseau ); //structure recevant les résultats de la mesure en mode réseau
	bool			StopReseau					( RDPRB_RESEAU_COUNT * pCountReseau );
	bool			StartMesure					( RDPRB_RESEAU_COUNT * pCountReseau );
	bool			StartReseauRS485			( RDPRB_RESEAU_COUNT * pCountReseau, BYTE * Serial); 
	bool			StopReseauRS485				( RDPRB_RESEAU_COUNT * pCountReseau, BYTE * Serial); 
	bool			StartMesureRS485			( RDPRB_RESEAU_COUNT * pCountReseau, BYTE * Serial); 
	bool			GetSerialNumRes				( char * pNumSerial, BYTE * SerialNumber); 
	bool			GetVersionRes				( char * pVersion, BYTE * Serial);
	bool			GetCSPName					( char * pCSPName, BYTE * Serial);
	bool			GetCSPBatCapa				( char * pCSPBatCapa,BYTE * Serial);
	bool			GetBaudRate					( long * baudRate , BYTE * Serial );
	bool			SetBaudRate					( long baudRate , BYTE * Serial);
	bool			SetCSPComInit				( long nbSel, BYTE * pCSPComSN);
	bool			SetCSPComSN					( BYTE * pCSPComSN);
	bool			GetSondeTypeRes				( char * status,
												  BYTE * pSerial);
	//CSP Com RF
	bool			LinkRepSup					( RDPRB_NETWORK_PARAM * pNetworkParam );
	bool			GetNetworkNumber			( RDPRB_NETWORK_PARAM * pNetworkParam );
	bool			RepSerialNumber				(BYTE * pSerial,bool receive);
	bool			RepDeployment				(BYTE NetworkNumber);
	bool			RepScan						(BYTE NetworkNumber,
												 RDPRB_NETWORK_PARAM * NetworkParam,
												 int * NbRepSup);
	bool			RepConnection				(RDPRB_NETWORK_PARAM * NetworkParam,
											     bool connect);
	bool			CSPScan						(BYTE NetworkNumber,
												 BOOL start);
	bool			CSPReadFrame				(BYTE * buffer,
												 int*  NbReceived);

	bool			CSPConnection				(BYTE *  NetworkNumber,
												 BYTE * CSPSN , 
												 BYTE * ConnectionParam);

	bool			CSPMeasure					(BYTE *  NetworkNumber,
												 bool start);

	bool			ReadMesure					(BYTE * Trame,
												RDPRB_RF_COUNT * pRFCount);

	bool			CSPRFGetParam				(BYTE  NetworkNumber,
												 BYTE ParamAddress, 
												 char * data , 
												 BYTE * Serial);
	bool			StopNetworkRF				(BYTE  NetworkNumber);

	//Fin CSP Com RF

	bool			GetExtCount					( RDPRB_DATA_EXT_COUNT * pCount);//	structure recevant les comptages 32 bits (FLOAT)
													
	bool			GetElectroMeas				( 
												  ELECTRONIC * pElectroMeas,		//	structure recevant les mesures électroniques
												  LPSTR * pMode);						//	chaîne de caractère recevant le mode de fonctionnement
										
	bool			GetProbeCode				( RDPRB_CODE_NAME * CodeName);		//	nom simple codé de la sonde
										
	bool			GetCurrentParam				( RDPRB_PARAM_FONC * pParamPrb);	//	structure recevant les paramètres courants
												 
	bool			GetSerialNum				( WORD * pNumSerial  );

	bool			GetUnitArray				( 
												  BYTE * pData,
												  UNIT_SYSTEM_TYPE system,
												  RDPRB_MIXTE_POS numPosition
												);

	bool			GetVersion					( BYTE * pVersion );

	bool			GetDoseRate					( RDPRB_DATA_DDD * pDoseRate );

	bool			GetIntegratedDose			( RDPRB_DATA_INTEG_DOSE * pIntegratedDose );

	bool			ClearSpectrum				( void );
	bool			StartSpectrumAcq			( void );
	bool			EndSpectrumAcq				( void );
	bool			GetSpectrum					( SPECTRUM_DATA * pSpectrum );
					
	// requêtes	d'écriture d'informations
	// ----------------------------------
	bool			SetAlrmLvlArray				( 
												  float * pData,
												  RDPRB_CODE_UNIT CodeUnit,
												  WORD IndexSeuil = NULL
												);												 

	bool			SetAlrmLvlIndexArray		( 
												  BYTE * pData,
												  COUNT_CHANNEL Channel,
												  RDPRB_CODE_UNIT CodeUnit = RDPRB_UNIT_CARD
												) ;

	bool			SetUnit						( RDPRB_DATA_UNIT * pUnitData);


//----------------------------------------------------------------------------
//							les accesseurs
//----------------------------------------------------------------------------

	// Considération des erreurs d'identification de la sonde
	// ------------------------------------------------------
	bool			IsErrName					( void )					{ return m_bNoErrName; }
	void			SetErrName					( bool noErr )				{ m_bNoErrName = noErr ; }
					
	// pour récupérer la dernière erreur numéro et message
	// ---------------------------------------------------
	RDPRB_ERR		GetLastError				( void )					{ return m_ErrComm; }

	LPSTR			GetLastErrorMsg				( void )					{ return m_csErrMsg; }
					
	// pour récupérer le statut de la communication
	// --------------------------------------------
	bool			GetCommInit					( void )					{ return m_bComOk;}
	void			SetCommInit					( bool m_bComTo)			{m_bComOk = m_bComTo;}
					
	// pour récupérer le nom du fichier d'enregistrement
	// -------------------------------------------------
	LPSTR			GetLogName					( void )					{ return m_LogName; }
					
	LOG_TYPE		GetLogType					( void )					{ return m_Log_Type; }

	bool					bUSB;//Communication USB
	bool					bRS485; //Utilisation d'un CSP Com RS485
	bool					bConfigBaudRate;

private:

	// Generated message map functions
#ifdef CSPCOM_EXPORTS
	bool					IsGoodProbeName				( RDPRB_CODE_NAME receiveName );
	bool					DisplayErr					( RDPRB_ERR typeErr );
	void					ResetStatusNameRecu			( void );
	LPSTR					DisplayMode					( RDPRB_ELECTRO_MEAS * pElectroMeas );
	bool					GetCriticalParam			( BYTE * pData, 
														  BYTE dataCount
														);
	void					MakeProbeName				( LPSTR * pName,
														  RDPRB_CODE_NAME nameCode,
														  float Surface
														);
	bool					GetCriticalParamEndAddr		( BYTE * pEndAddr		);
	bool					FillCriticalParam			( CRIT_PARAM * pCriticalParam, 
														  BYTE * pBuffer 
														);
	bool					SaveCount					( RDPRB_DATA_COUNT * pCount );
	bool					SaveCountRes				( RDPRB_RESEAU_COUNT * pCountReseau);
	bool					SaveExtCount				( RDPRB_DATA_EXT_COUNT * pCount );
	bool					SaveDoseRate				( RDPRB_DATA_DDD * pDoseRate );
	bool					SaveIntegDose				( RDPRB_DATA_INTEG_DOSE * pDoseRate );
#else
#endif

	RDPRB_COMMON_HEADER	*	m_pCommon;					// structure de la trame commune
	RDPRB_CODE_STATUS		m_ServiceStatus;			// statut de la sonde
	bool					m_bComOk;					// booléen vérifiant l'état de la communication avec la sonde
	LPSTR					m_csErrMsg;					// chaîne de caractères stockant le message d'erreur
	RDPRB_ERR				m_ErrComm;					// Code de l'erreur
	CSPComInit				m_Init;						// structure des paramètres pour l'ouverture du port de communication.
	char					m_LogName[30];				// Nom du fichier sous lequel les données seront sauvegardées
	LOG_TYPE				m_Log_Type;					// Type d'enregistrement
	long					nbSelected;
	long					IndexSelected;

	// on peut s'autoriser (si m_bNoErrName = true) à considérer comme bonne 
	// des réponses de sondes à qui on ne s'adresse pas.
	// Dans le cas notamment de la prémière programmation d'une sonde le code
	// NAME contenu dans la réponse sera forcément mauvais.
	bool					m_bNoErrName;				// gestion des erreurs de nom des sondes
};

//----------------------------------------------------------------------------
//
//			F o n c t i o n s   d e   C o m p a t i b i l i t é
//
//
//	Ces fonctions permettent d'exporter les fonctions de la classe pour des
//	langages ne supportant pas les classes C++. Elles sont appelées wrappers
//	car elles ne font que rappeler les fonctions
//
//----------------------------------------------------------------------------

	
	CCSPCom *	__stdcall		Initialize					( );							//wrapper

	void		__stdcall		StopProg					( CCSPCom * pCSPCom );				//wrapper

	//	définition du type d'enregistrement
	// ------------------------------------
	bool		__stdcall		SetLog						( CCSPCom * pCSPCom, LPSTR * Name,	//wrapper
															  LOG_TYPE log_type
															);

	// ouverture fermeture du port
	// ---------------------------
	bool		__stdcall		InitComm					( CCSPCom * pCSPCom,				//wrapper
															  RDPRB_COMMON_HEADER * pCommon, 
															  LPSTR Port,
															  long Baud,
															  long Tmo1,
															  long Tmo2
															);
	
	bool		__stdcall		CloseComm					( CCSPCom * pCSPCom );				//wrapper

	// requêtes de lecture d'informations
	// ----------------------------------
	bool		__stdcall		GetAlrmLvlArray				( CCSPCom * pCSPCom,				//wrapper
															  float * pData, 
															  RDPRB_CODE_UNIT CodeUnit,
															  WORD IndexSeuil
															);
	
	bool		__stdcall		GetAlrmLvlIndexArray		( CCSPCom * pCSPCom,				//wrapper
															  BYTE * pData,
															  COUNT_CHANNEL Channel,
															  RDPRB_CODE_UNIT CodeUnit															  
															);
	
	bool		__stdcall		GetCriticalParameter		( CCSPCom * pCSPCom,				//wrapper
															  CRIT_PARAM * pCriticalParam
															);
	
	bool		__stdcall		GetCount					( CCSPCom * pCSPCom,				//wrapper
															  WORD * pCount1,
															  WORD * pCount2
															);
	
	bool		__stdcall		GetExtCount					( CCSPCom * pCSPCom,				//wrapper
															  float * pExtCount1,
															  float * pExtCount2
															);

	bool		__stdcall		GetDoseRate					( CCSPCom * pCSPCom,				//wrapper
															  float * pDoseRateSnap1,
															  float * pDoseRateSmooth1,
															  float * pDoseRateSnap2,
															  float * pDoseRateSmooth2,
															  float * pIntegDose1,
															  float * pIntegDose2,
															  WORD *  pIntegTime
															);

	bool		__stdcall		GetIntegratedDose			( CCSPCom * pCSPCom,
															  float * pIntegDose1,
															  float * pIntegDose2,
															  WORD *  pIntegTime
															);

	bool		__stdcall		GetElectroMeas				( CCSPCom * pCSPCom,				//wrapper
															  ELECTRONIC * pElectroMeas,
															  LPSTR * pMode
															);

	bool		__stdcall		GetProbeCode				( CCSPCom * pCSPCom,				//wrapper
															  RDPRB_CODE_NAME * CodeName
															);

	bool		__stdcall		GetCurrentParam				( CCSPCom * CSPCom,					//wrapper
															  RDPRB_PARAM_FONC * pParamPrb
															);

	bool		__stdcall		GetSerialNum				( CCSPCom * pCSPCom,				//wrapper
															  WORD * pNumSerial
															);

	bool		__stdcall		GetUnitArray				( CCSPCom * pCSPCom,				//wrapper
															  BYTE * pData, 
															  UNIT_SYSTEM_TYPE system,
															  RDPRB_MIXTE_POS numPosition
															);

	bool		__stdcall		GetVersion					( CCSPCom * pCSPCom,				//wrapper
															  BYTE * pVersion
															);

	//wrapper des fonctions CPS Com
	bool		__stdcall		GetVersionRes				( CCSPCom * pCSPCom,
															  char * pVersion,
															  BYTE * pSerial
															 );

	bool		__stdcall		StartReseau					( CCSPCom * pCSPCom,
															  RDPRB_RESEAU_COUNT * pCountReseau );

	bool		__stdcall		StopReseau					( CCSPCom * pCSPCom,
															  RDPRB_RESEAU_COUNT * pCountReseau );

	bool		__stdcall		StartMesure					(CCSPCom * pCSPCom,
															 RDPRB_RESEAU_COUNT * pCountReseau );

	bool		__stdcall		StartReseauRS485			( CCSPCom * pCSPCom,
															  RDPRB_RESEAU_COUNT * pCountReseau,
															  BYTE * pSerial);

	bool		__stdcall		StopReseauRS485				( CCSPCom * pCSPCom,
															  RDPRB_RESEAU_COUNT * pCountReseau,
															  BYTE * pSerial);

	bool		__stdcall		StartMesureRS485			( CCSPCom * pCSPCom,
															  RDPRB_RESEAU_COUNT * pCountReseau,
															  BYTE * pSerial);

	bool		__stdcall		GetSerialNumRes				( CCSPCom * pCSPCom,
															  char * pNumSerial, 
															  BYTE * SerialNumber); 

	bool		__stdcall		GetCSPName					( CCSPCom * pCSPCom,
															  char * pCSPName, 
															  BYTE * pSerial); 

	bool		__stdcall		GetCSPBatCapa				( CCSPCom * pCSPCom,
															  char * pCSPBatCapa, 
															  BYTE * pSerial); 

	bool		__stdcall		GetBaudRate					( CCSPCom * pCSPCom,
															  long * baudRate, 
															  BYTE * pSerial);
		
	bool		__stdcall		SetBaudRate					( CCSPCom * pCSPCom,
															  long baudRate, 
															  BYTE * pSerial);

	bool		__stdcall		SetCSPComInit				( CCSPCom * pCSPCom,
															  long nbSel,
															  BYTE * pSerial); 

    bool		__stdcall		SetCSPComInitRS				( CCSPCom * pCSPCom,
															  long nbSel,
															  BYTE * pSerial,
															  LPSTR Port);

	bool		__stdcall		GetSondeTypeRes				( CCSPCom * pCSPCom,
															  char * type);

	// requêtes d'écriture d'informations
	// ----------------------------------
	bool		__stdcall		SetAlrmLvlArray				( CCSPCom * pCSPCom,				//wrapper
															  float * pData,
															  RDPRB_CODE_UNIT CodeUnit,
															  WORD IndexSeuil
															);

	bool		__stdcall		SetAlrmLvlIndexArray		( CCSPCom * pCSPCom,				//wrapper
															  BYTE * pData,
															  COUNT_CHANNEL Channel,
															  RDPRB_CODE_UNIT CodeUnit
															);

	bool		__stdcall		SetUnit						( CCSPCom * pCSPCom,				//wrapper
															  RDPRB_DATA_UNIT * pUnitData
															);

	bool		__stdcall		SaveData					( CCSPCom * pCSPCom,				//wrapper
															  LPSTR DataType, 
															  LPSTR Data
															);


	// les accesseurs
	// --------------
	bool		__stdcall		IsErrName					( CCSPCom * pCSPCom );				//wrapper
	
	void		__stdcall		SetErrName					( CCSPCom * pCSPCom,				//wrapper
															  bool noErr 
															);

	// pour récupérer la dernière erreur numéro et message
	RDPRB_ERR	__stdcall		GetLastError				( CCSPCom * pCSPCom );				//wrapper
	
	void		__stdcall		GetLastErrorMsg				( CCSPCom * pCSPCom,				//wrapper
															  LPSTR * ErrMsg 
															);
	//pour récupérer le statut de la communication
	bool		__stdcall		GetCommInit					( CCSPCom * pCSPCom );				//wrapper

	//pour récupérer le nom du fichier d'enregistrement
	void		__stdcall		GetLogName					( CCSPCom * pCSPCom,				//wrapper
															  LPSTR * LogName
															);

//Récupération d'un numéro des ports de communication ouverts
CSPCOM_DLL	bool		__stdcall		GetPortName					(	LPSTR * pPort,
																	  int AddrIndex = 0);

#endif // !defined(AFX_CSPCOM_H__61FE7281_1E80_4360_96DA_32FA999EE42C__INCLUDED_)
