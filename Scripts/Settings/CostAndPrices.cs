/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// Cost and prices.cs
/// 
/// </summary>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;


/// <ToDo>
/// add soldier section to save/load.
/// </ToDo>
/// 
public class CostAndPrices : MonoBehaviour {
	public static CostAndPrices CAP;
	#region characters
	// Soldier prices are the same for all factions
	[SerializeField]public int CareerUpdateCred = 114000;
	[SerializeField]public int  CareerUpdateGold = 450;
	// infantry
	[SerializeField]public int BuyPrivateInfCred = 9200;
	[SerializeField]public int  BuyPrivateInfGold = 110;

	[SerializeField]public int PrivateInfSalary = 7600;

	[SerializeField]public int Buy2ndLutInfCred = 210000;
	[SerializeField]public int Buy2ndLutInfGold = 2100;

	[SerializeField]public int SecondLieuntenantInfSalary = 13300;

	[SerializeField]public int BuyMajorInfCred = 489000;
	[SerializeField]public int BuyMajorInfGold = 4500;

	[SerializeField]public int MajorInfSalary = 14800;

	// para
	[SerializeField]public int BuyPrivateParaCred = 71000;
	[SerializeField]public int  BuyPrivateParaGold = 850;

	[SerializeField]public int PrivateParaSalary = 7600;

	[SerializeField]public int Buy2ndLutParaCred = 359000;
	[SerializeField]public int Buy2ndLutParaGold = 3700;

	[SerializeField]public int SecondLieuntenantParaSalary = 13300;

	[SerializeField]public int BuyMajorParaCred = 715000;
	[SerializeField]public int BuyMajorParaGold = 6250;

	[SerializeField]public int MajorParaSalary = 14800;

	//recon
	[SerializeField]public int BuyPrivateReconCred = 208000;
	[SerializeField]public int  BuyPrivateReconGold = 2500;

	[SerializeField]public int PrivateReconSalary = 7600;

	[SerializeField]public int Buy2ndLutReconCred = 592000;
	[SerializeField]public int Buy2ndLutReconGold = 5300;

	[SerializeField]public int SecondLieuntenantReconSalary = 13300;

	[SerializeField]public int BuyMajorReconCred = 950000;
	[SerializeField]public int BuyMajorReconGold = 8000;
	[SerializeField]public int MajorReconSalary = 14800;

	// tanker
	[SerializeField]public int BuyPrivateTankerCred = 120000;
	[SerializeField]public int  BuyPrivateTankerGold = 1200;

	[SerializeField]public int PrivateTankerSalary = 7600;

	[SerializeField]public int Buy2ndLutTankerCred = 395000;
	[SerializeField]public int Buy2ndLutTankerGold = 3700;

	[SerializeField]public int SecondLieuntenantTankerSalary = 13300;

	[SerializeField]public int BuyMajorTankerCred = 715000;
	[SerializeField]public int BuyMajorTankerGold = 6250;
	[SerializeField]public int MajorTankerSalary = 14800;

	// pilot
	[SerializeField]public int BuyPrivatePilotCred = 200000;
	[SerializeField]public int  BuyPrivatePilotGold = 2000;

	[SerializeField]public int PrivatePilotSalary = 7600;

	[SerializeField]public int Buy2ndLutPilotCred = 395000;
	[SerializeField]public int Buy2ndLutPilotGold = 3700;

	[SerializeField]public int SecondLieuntenantPilotSalary = 13300;

	[SerializeField]public int BuyMajorPilotCred = 579000;
	[SerializeField]public int BuyMajorPilotGold = 5200;

	[SerializeField]public int MajorPilotSalary = 14800;

	// General
	[SerializeField]public int BuyGeneralCred = 1969000;
	[SerializeField]public int BuyGeneralGold = 9900;
	#endregion

	#region assault teams
	// Assault Teams
	//Cost Buy / Upgrade Warfunds or Gold
	//Guard to Mechanized infantry
	[SerializeField]public int BuyGuardWarfunds = 28500;
	[SerializeField]public int BuyGuardGold = 992;
	[SerializeField]public int UpgradeToMotorGuardWF = 24000;
	[SerializeField]public int UgradeToMotorGuardGold = 80;
	[SerializeField]public int UgradeToInfantryWF = 14000;
	[SerializeField]public int UgradeToInfantryGold = 51;
	[SerializeField]public int UgradeToMotorInfantryWF = 30000;
	[SerializeField]public int UgradeToMotorInfantryGold = 96;
	[SerializeField]public int UgradeToMechInfantryWF = 30000;
	[SerializeField]public int UgradeToMechInfantryGold = 96;

	//Recon
	[SerializeField]public int BuyReconWarfunds = 28500;
	[SerializeField]public int BuyReconGold = 992;
	[SerializeField]public int UgradeToMotorReconWarfunds = 24000;
	[SerializeField]public int UgradeToMotorReconGold = 80;
	[SerializeField]public int UgradeToMechReconWarfunds = 24000;
	[SerializeField]public int UgradeToMechReconGold = 80;

	//Para
	[SerializeField]public int BuyPathfinderWarfunds = 60500;
	[SerializeField]public int BuyPathfinderGold = 1089;
	[SerializeField]public int UgradeToParatrooperWF = 46500;
	[SerializeField]public int UgradeToParatrooperGold = 149;

	//Light to Heavy armor
	[SerializeField]public int BuyLightArmorWarfunds = 44500;
	[SerializeField]public int BuyPLightArmorGold = 1049;
	[SerializeField]public int UgradeToMediumArmorWF = 30000;
	[SerializeField]public int UgradeToMediumArmorGold = 96;
	[SerializeField]public int UgradeToHeavyArmorWF = 30000;
	[SerializeField]public int UgradeToHeavyArmorGold = 96;
	[SerializeField]public int UgradeToTankDestroyerWF = 24000;
	[SerializeField]public int UgradeToTankDestroyerGold = 80;

	//Fighter to fighters
	[SerializeField]public int BuyReconFighterWarfunds = 60500;
	[SerializeField]public int BuyReconFighterGold = 1089;
	[SerializeField]public int UgradeToMediumFightersWarfunds = 46000;
	[SerializeField]public int UgradeToMediumFighterGold = 149;
	[SerializeField]public int UgradeToHeavyFighterWarfunds = 46000;
	[SerializeField]public int UgradeToHeavyFighterGold = 149;

	//Total Reinforce cost warfunds or gold	
	//Guard to Mechanized infantry
	[SerializeField]public int ReinfGuardWarfunds = 28500;
	[SerializeField]public int ReinfGuardGold = 992;
	[SerializeField]public int ReinfMotorGuardWF = 24000;
	[SerializeField]public int ReinfMotorGuardGold = 80;
	[SerializeField]public int ReinfInfantryWF = 14000;
	[SerializeField]public int ReinfInfantryGold = 51;
	[SerializeField]public int ReinfMotorInfantryWF = 30000;
	[SerializeField]public int ReinfMotorInfantryGold = 96;
	[SerializeField]public int ReinfoMechInfantryWF = 30000;
	[SerializeField]public int ReinfMechInfantryGold = 96;

	//Recon
	[SerializeField]public int ReinfReconWarfunds = 28500;
	[SerializeField]public int ReinfReconGold = 992;
	[SerializeField]public int ReinfMotorReconWarfunds = 24000;
	[SerializeField]public int ReinfMotorReconGold = 80;
	[SerializeField]public int ReinfMechReconWarfunds = 24000;
	[SerializeField]public int ReinfMechReconGold = 80;

	//Para
	[SerializeField]public int ReinfathfinderWarfunds = 60500;
	[SerializeField]public int ReinfPathfinderGold = 1089;
	[SerializeField]public int ReinfParatrooperWF = 46500;
	[SerializeField]public int ReinfParatrooperGold = 149;

	//Light to Heavy armor
	[SerializeField]public int ReinfLightArmorWarfunds = 44500;
	[SerializeField]public int ReinfPLightArmorGold = 1049;
	[SerializeField]public int ReinfMediumArmorWF = 30000;
	[SerializeField]public int ReinfMediumArmorGold = 96;
	[SerializeField]public int ReinfHeavyArmorWF = 30000;
	[SerializeField]public int ReinfHeavyArmorGold = 96;
	[SerializeField]public int ReinfTankDestroyerWF = 24000;
	[SerializeField]public int ReinfTankDestroyerGold = 80;

	//Fighter to fighters
	[SerializeField]public int ReinfReconFighterWarfunds = 60500;
	[SerializeField]public int ReinfReconFighterGold = 1089;
	[SerializeField]public int ReinfMediumFightersWarfunds = 46000;
	[SerializeField]public int ReinfMediumFighterGold = 149;
	[SerializeField]public int ReinfHeavyFighterWarfunds = 46000;
	[SerializeField]public int ReinfHeavyFighterGold = 149;
	#endregion
	//Total Deploy Cost

	//Manpower/Vehicles

	void Awake () {
		if (CAP == null) {
			//DontDestroyOnLoad (gameObject);
			CAP = this;
		} else if (CAP != this) {
			//Destroy (gameObject);
		}

	}

	public void SaveCosts(){

		BinaryFormatter cap = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/CostAndPricesData.4thId");

		CostAndPricesData data = new CostAndPricesData ();
		// Assault Team
		//Cost Buy / Upgrade Warfunds or Gold
		//Guard to Mechanized infantry
		data._BuyGuardWarfunds = BuyGuardWarfunds;
		data._BuyGuardGold = BuyGuardGold;
		data._UpgradeToMotorGuardWF = UpgradeToMotorGuardWF;
		data._UgradeToMotorGuardGold = UgradeToMotorGuardGold;
		data._UgradeToInfantryWF = UgradeToInfantryWF;
		data._UgradeToInfantryGold = UgradeToInfantryGold;
		data._UgradeToMotorInfantryWF = UgradeToMotorInfantryWF;
		data._UgradeToMotorInfantryGold = UgradeToMotorInfantryGold;
		data._UgradeToMechInfantryWF = UgradeToMechInfantryWF;
		data._UgradeToMechInfantryGold = UgradeToMechInfantryGold;

		//Recon
		data._BuyReconWarfunds = BuyReconWarfunds;
		data._BuyReconGold = BuyReconGold;
		data._UgradeToMotorReconWarfunds = UgradeToMotorReconWarfunds;
		data._UgradeToMotorReconGold = UgradeToMotorReconGold;
		data._UgradeToMechReconWarfunds = UgradeToMechReconWarfunds;
		data._UgradeToMechReconGold = UgradeToMechReconGold;

		//Para
		data._BuyPathfinderWarfunds = BuyPathfinderWarfunds;
		data._BuyPathfinderGold = BuyPathfinderGold;
		data._UgradeToParatrooperWF = UgradeToParatrooperWF;
		data._UgradeToParatrooperGold = UgradeToParatrooperGold;

		//Light to Heavy armor
		data._BuyLightArmorWarfunds = BuyLightArmorWarfunds;
		data._BuyPLightArmorGold = BuyPLightArmorGold;
		data._UgradeToMediumArmorWF = UgradeToMediumArmorWF;
		data._UgradeToMediumArmorGold = UgradeToMediumArmorGold;
		data._UgradeToHeavyArmorWF = UgradeToHeavyArmorWF;
		data._UgradeToHeavyArmorGold = UgradeToHeavyArmorGold;
		data._UgradeToTankDestroyerWF = UgradeToTankDestroyerWF;
		data._UgradeToTankDestroyerGold = UgradeToTankDestroyerGold;

		//Fighter to fighters
		data._BuyReconFighterWarfunds = BuyReconFighterWarfunds;
		data._BuyReconFighterGold = BuyReconFighterGold;
		data._UgradeToMediumFightersWarfunds = UgradeToMediumFightersWarfunds;
		data._UgradeToMediumFighterGold = UgradeToMediumFighterGold;
		data._UgradeToHeavyFighterWarfunds = UgradeToHeavyFighterWarfunds;
		data._UgradeToHeavyFighterGold = UgradeToHeavyFighterGold;

		//Total Reinforce cost warfunds or gold	
		//Guard to Mechanized infantry
		data._ReinfGuardWarfunds = ReinfGuardWarfunds;
		data._ReinfGuardGold = ReinfGuardGold;
		data._ReinfMotorGuardWF = ReinfMotorGuardWF;
		data._ReinfMotorGuardGold = ReinfMotorGuardGold;
		data._ReinfInfantryWF = ReinfInfantryWF;
		data._ReinfInfantryGold = ReinfInfantryGold;
		data._ReinfMotorInfantryWF = ReinfMotorInfantryWF;
		data._ReinfMotorInfantryGold = ReinfMotorInfantryGold;
		data._ReinfoMechInfantryWF = ReinfoMechInfantryWF;
		data._ReinfMechInfantryGold = ReinfMechInfantryGold;

		//Recon
		data._ReinfReconWarfunds = ReinfReconWarfunds;
		data._ReinfReconGold = ReinfReconGold;
		data._ReinfMotorReconWarfunds = ReinfMotorReconWarfunds;
		data._ReinfMotorReconGold = ReinfMotorReconGold;
		data._ReinfMechReconWarfunds = ReinfMechReconWarfunds;
		data._ReinfMechReconGold = ReinfMechReconGold;

		//Para
		data._ReinfathfinderWarfunds = ReinfathfinderWarfunds;
		data._ReinfPathfinderGold = ReinfPathfinderGold;
		data._ReinfParatrooperWF = ReinfParatrooperWF;
		data._ReinfParatrooperGold = ReinfParatrooperGold;

		//Light to Heavy armor
		data._ReinfLightArmorWarfunds = ReinfLightArmorWarfunds;
		data._ReinfPLightArmorGold = ReinfPLightArmorGold;
		data._ReinfMediumArmorWF = ReinfMediumArmorWF;
		data._ReinfMediumArmorGold = ReinfMediumArmorGold;
		data._ReinfHeavyArmorWF = ReinfHeavyArmorWF;
		data._ReinfHeavyArmorGold = ReinfHeavyArmorGold;
		data._ReinfTankDestroyerWF = ReinfTankDestroyerWF;
		data._ReinfTankDestroyerGold = ReinfTankDestroyerGold;

		//Fighter to fighters
		data._ReinfReconFighterWarfunds = ReinfReconFighterWarfunds;
		data._ReinfReconFighterGold = ReinfReconFighterGold;
		data._ReinfMediumFightersWarfunds = ReinfMediumFightersWarfunds;
		data._ReinfMediumFighterGold = ReinfMediumFighterGold;
		data._ReinfHeavyFighterWarfunds = ReinfHeavyFighterWarfunds;
		data._ReinfHeavyFighterGold = ReinfHeavyFighterGold;


		cap.Serialize (file, data);
		file.Close ();
	}

	public void LoadCosts(){
		if(File.Exists(Application.persistentDataPath + "/CostAndPricesData.4thId")){
			BinaryFormatter cap = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/CostAndPricesData.4thId", FileMode.Open);
			CostAndPricesData data = (CostAndPricesData)cap.Deserialize (file);
			file.Close ();


			// Assault Team
			//Cost Buy / Upgrade Warfunds or Gold
			//Guard to Mechanized infantry
			BuyGuardWarfunds = data._BuyGuardWarfunds;
			BuyGuardGold = data._BuyGuardGold;
			UpgradeToMotorGuardWF = data._UpgradeToMotorGuardWF;
			UgradeToMotorGuardGold = data._UgradeToMotorGuardGold;
			UgradeToInfantryWF = data._UgradeToInfantryWF;
			UgradeToInfantryGold = data._UgradeToInfantryGold;
			UgradeToMotorInfantryWF = data._UgradeToMotorInfantryWF;
			UgradeToMotorInfantryGold = data._UgradeToMotorInfantryGold;
			UgradeToMechInfantryWF = data._UgradeToMechInfantryWF;
			UgradeToMechInfantryGold = data._UgradeToMechInfantryGold;

			//Recon
			BuyReconWarfunds = data._BuyReconWarfunds;
			BuyReconGold = data._BuyReconGold;
			UgradeToMotorReconWarfunds = data._UgradeToMotorReconWarfunds;
			UgradeToMotorReconGold = data._UgradeToMotorReconGold;
			UgradeToMechReconWarfunds = data._UgradeToMechReconWarfunds;
			UgradeToMechReconGold = data._UgradeToMechReconGold;

			//Para
			BuyPathfinderWarfunds = data._BuyPathfinderWarfunds;
			BuyPathfinderGold = data._BuyPathfinderGold;
			UgradeToParatrooperWF = data._UgradeToParatrooperWF;
			UgradeToParatrooperGold = data._UgradeToParatrooperGold;

			//Light to Heavy armor
			BuyLightArmorWarfunds =data._BuyLightArmorWarfunds;
			BuyPLightArmorGold = data._BuyPLightArmorGold;
			UgradeToMediumArmorWF = data._UgradeToMediumArmorWF;
			UgradeToMediumArmorGold = data._UgradeToMediumArmorGold;
			UgradeToHeavyArmorWF = data._UgradeToHeavyArmorWF;
			UgradeToHeavyArmorGold = data._UgradeToHeavyArmorGold;
			UgradeToTankDestroyerWF = data._UgradeToTankDestroyerWF;
			UgradeToTankDestroyerGold = data._UgradeToTankDestroyerGold;

			//Fighter to fighters
			BuyReconFighterWarfunds = data._BuyReconFighterWarfunds;
			BuyReconFighterGold = data._BuyReconFighterGold;
			UgradeToMediumFightersWarfunds = data._UgradeToMediumFightersWarfunds;
			UgradeToMediumFighterGold = data._UgradeToMediumFighterGold;
			UgradeToHeavyFighterWarfunds = data._UgradeToHeavyFighterWarfunds;
			UgradeToHeavyFighterGold = data._UgradeToHeavyFighterGold;

			//Total Reinforce cost warfunds or gold	
			//Guard to Mechanized infantry
			ReinfGuardWarfunds = data._ReinfGuardWarfunds;
			ReinfGuardGold = data._ReinfGuardGold;
			ReinfMotorGuardWF = data._ReinfMotorGuardWF;
			ReinfMotorGuardGold = data._ReinfMotorGuardGold;
			ReinfInfantryWF = data._ReinfInfantryWF;
			ReinfInfantryGold = data._ReinfInfantryGold;
			ReinfMotorInfantryWF = data._ReinfMotorInfantryWF;
			ReinfMotorInfantryGold = data._ReinfMotorInfantryGold;
			ReinfoMechInfantryWF = data._ReinfoMechInfantryWF;
			ReinfReconWarfunds = data._ReinfReconWarfunds;
			ReinfReconGold = data._ReinfReconGold;
			ReinfMotorReconWarfunds = data._ReinfMotorReconWarfunds;
			ReinfMotorReconGold = data._ReinfMotorReconGold;
			ReinfMechReconWarfunds = data._ReinfMechReconWarfunds;
			ReinfMechReconGold = data._ReinfMechReconGold;

			//Para
			ReinfathfinderWarfunds = data._ReinfathfinderWarfunds;
			ReinfPathfinderGold = data._ReinfPathfinderGold;
			ReinfParatrooperWF = data._ReinfParatrooperWF;
			ReinfParatrooperGold = data._ReinfParatrooperGold;

			//Light to Heavy armor
			ReinfLightArmorWarfunds = data._ReinfLightArmorWarfunds;
			ReinfPLightArmorGold = data._ReinfPLightArmorGold;
			ReinfMediumArmorWF = data._ReinfMediumArmorWF;
			ReinfMediumArmorGold = data._ReinfMediumArmorGold;
			ReinfHeavyArmorWF = data._ReinfMediumArmorGold;
			ReinfHeavyArmorGold = data._ReinfHeavyArmorGold;
			ReinfTankDestroyerWF = data._ReinfTankDestroyerWF;
			ReinfTankDestroyerGold = data._ReinfTankDestroyerGold;

			//Fighter to fighters
			ReinfReconFighterWarfunds = data._ReinfReconFighterWarfunds;
			ReinfReconFighterGold = data._ReinfReconFighterGold;
			ReinfMediumFightersWarfunds = data._ReinfMediumFightersWarfunds;
			ReinfMediumFighterGold = data._ReinfMediumFighterGold;
			ReinfHeavyFighterWarfunds = data._ReinfHeavyFighterWarfunds;
			ReinfHeavyFighterGold = data._ReinfHeavyFighterGold;

		}
	}
}

// the class to save and load the pricedata

[Serializable]
class CostAndPricesData{

	//[Serializable]
	// Assault Team
	//Cost Buy / Upgrade Warfunds or Gold
	//Guard to Mechanized infantry
	public int _BuyGuardWarfunds;
	public int _BuyGuardGold;
	public int _UpgradeToMotorGuardWF;
	public int _UgradeToMotorGuardGold;
	public int _UgradeToInfantryWF;
	public int _UgradeToInfantryGold;
	public int _UgradeToMotorInfantryWF;
	public int _UgradeToMotorInfantryGold;
	public int _UgradeToMechInfantryWF;
	public int _UgradeToMechInfantryGold;

	//Recon
	public int _BuyReconWarfunds;
	public int _BuyReconGold;
	public int _UgradeToMotorReconWarfunds;
	public int _UgradeToMotorReconGold;
	public int _UgradeToMechReconWarfunds;
	public int _UgradeToMechReconGold;

	//Para
	public int _BuyPathfinderWarfunds;
	public int _BuyPathfinderGold;
	public int _UgradeToParatrooperWF;
	public int _UgradeToParatrooperGold;

	//Light to Heavy armor
	public int _BuyLightArmorWarfunds;
	public int _BuyPLightArmorGold;
	public int _UgradeToMediumArmorWF;
	public int _UgradeToMediumArmorGold;
	public int _UgradeToHeavyArmorWF;
	public int _UgradeToHeavyArmorGold;
	public int _UgradeToTankDestroyerWF;
	public int _UgradeToTankDestroyerGold;

	//Fighter to fighters
	public int _BuyReconFighterWarfunds;
	public int _BuyReconFighterGold;
	public int _UgradeToMediumFightersWarfunds;
	public int _UgradeToMediumFighterGold;
	public int _UgradeToHeavyFighterWarfunds;
	public int _UgradeToHeavyFighterGold;

	//Total Reinforce cost warfunds or gold	
	//Guard to Mechanized infantry
	public int _ReinfGuardWarfunds;
	public int _ReinfGuardGold;
	public int _ReinfMotorGuardWF;
	public int _ReinfMotorGuardGold;
	public int _ReinfInfantryWF;
	public int _ReinfInfantryGold;
	public int _ReinfMotorInfantryWF;
	public int _ReinfMotorInfantryGold;
	public int _ReinfoMechInfantryWF;
	public int _ReinfMechInfantryGold;

	//Recon
	public int _ReinfReconWarfunds;
	public int _ReinfReconGold;
	public int _ReinfMotorReconWarfunds;
	public int _ReinfMotorReconGold;
	public int _ReinfMechReconWarfunds;
	public int _ReinfMechReconGold;

	//Para
	public int _ReinfathfinderWarfunds;
	public int _ReinfPathfinderGold;
	public int _ReinfParatrooperWF;
	public int _ReinfParatrooperGold;

	//Light to Heavy armor
	public int _ReinfLightArmorWarfunds;
	public int _ReinfPLightArmorGold;
	public int _ReinfMediumArmorWF;
	public int _ReinfMediumArmorGold;
	public int _ReinfHeavyArmorWF;
	public int _ReinfHeavyArmorGold;
	public int _ReinfTankDestroyerWF;
	public int _ReinfTankDestroyerGold;

	//Fighter to fighters
	public int _ReinfReconFighterWarfunds;
	public int _ReinfReconFighterGold;
	public int _ReinfMediumFightersWarfunds;
	public int _ReinfMediumFighterGold;
	public int _ReinfHeavyFighterWarfunds;
	public int _ReinfHeavyFighterGold;
}

