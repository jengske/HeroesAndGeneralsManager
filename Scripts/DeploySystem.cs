using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySystem : MonoBehaviour {
	public static DeploySystem DS;

	private Faction us; 
	private Faction germ;
	private Faction sov;

	private Faction usa; 
	private Faction germany;
	private Faction soviet;

	public int usdeploy;
	public int germdeploy;
	public int sovdeploy;

	public RectTransform deployview;
	public GameObject deploygroup;

	void Awake () {
		// only one instance allowed
		if (DS == null) {
			//DontDestroyOnLoad (gameObject);
			DS = this;
		} else if (DS != this) {
			Destroy (gameObject);
		}

		us = FactionManager.control.USFaction;
		germ = FactionManager.control.GERMANFaction;
		sov = FactionManager.control.SOVIETFaction;

		usa = FactionManager.control.Factions["US"];
		germany = FactionManager.control.Factions["GERMANY"];
		soviet = FactionManager.control.Factions["SOVIET"];
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// check the dictionairies
		us = FactionManager.control.USFaction;
		germ = FactionManager.control.GERMANFaction;
		sov = FactionManager.control.SOVIETFaction;

		usa = FactionManager.control.Factions["US"];
		germany = FactionManager.control.Factions["GERMANY"];
		soviet = FactionManager.control.Factions["SOVIET"];

		if(Input.GetKeyDown(KeyCode.DownArrow)){
			//test();
		}
		// check if character has deployed assaultteams
//		foreach (Character Character in us.Characters) {
//			if(Character.AssaultTeamsDeployed.Count <= 0){
//				Character.hasDeploy = false;
//				Character.setActiveCommandPoints (Character.CommandPoints);
//			}else{
//				Character.hasDeploy = true;
//
//			}
//		}
//
//		foreach (Character Character in germ.Characters) {
//			if(Character.AssaultTeamsDeployed.Count <= 0){
//				Character.hasDeploy = false;
//				Character.setActiveCommandPoints (Character.CommandPoints);
//			}else{
//				Character.hasDeploy = true;
//			}
//		}
//
//		foreach (Character Character in sov.Characters) {
//			if(Character.AssaultTeamsDeployed.Count <= 0){
//				Character.hasDeploy = false;
//				Character.setActiveCommandPoints (Character.CommandPoints);
//			}else{
//				Character.hasDeploy = true;
//			}
//		}

		usdeploy = GetUSDeployed ();
		germdeploy = GetGERMANDeployed ();
		sovdeploy = GetSOVIETDeployed ();
	}


	// add to the deploy list
//	public void SetReadyForDeploy(bool istes, Character c, AssaultTeam at, int id, ATHolder ats){
//		Debug.LogError ("SetReadyForDeploy");
//		//		if (FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed == null) {
//		//			FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed = new Dictionary<int, AssaultTeam> ();
//		//			Debug.LogError ("ATManager: nothing found");
//		//		}
//
//		Debug.LogError ("ATManager: isTest ");
//		switch(at.AT_Type){
//		case AssaultTeam.AT_Types.Guard:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfGuardWarfunds) == true) {
//					Debug.LogError ("switch check true");
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfGuardWarfunds;
//				} else {
//					Debug.LogError ("switch check false");
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfGuardGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfGuardGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Motorized_Guard:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorGuardWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorGuardWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorGuardGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorGuardGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Infantry:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfInfantryWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfInfantryWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfInfantryGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfInfantryGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Motorized_Infantry:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorInfantryWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorInfantryWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorInfantryGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorInfantryGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Mechanized_Infantry:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfoMechInfantryWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfoMechInfantryWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMechInfantryGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMechInfantryGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Recon:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfReconWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfReconWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfReconGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfReconGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Motorized_Recon:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorReconWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorReconWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorReconGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorReconGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Mechanized_Recon:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMechReconWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMechReconWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMechReconGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMechReconGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Light_Armor:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfLightArmorWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfLightArmorWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfPLightArmorGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfPLightArmorGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Medium_Armor:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMediumArmorWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMediumArmorWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMediumArmorGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMediumArmorGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.MediumTankDestroyer:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfTankDestroyerWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfTankDestroyerWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfTankDestroyerGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfTankDestroyerGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Heavy_Armor:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfHeavyArmorWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfHeavyArmorWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfHeavyArmorGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfHeavyArmorGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Pathfinders:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfathfinderWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfathfinderWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfPathfinderGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfPathfinderGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Paratroopers:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfParatrooperWF) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfParatrooperWF;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold,  CostAndPrices.CAP.ReinfParatrooperGold) == true) {
//
//					GameControl.control.Gold -=  CostAndPrices.CAP.ReinfParatrooperGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Fighter_Recon:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfReconFighterWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfReconFighterWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfReconFighterGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfReconFighterGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Fighter_Squadron:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMediumFightersWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMediumFightersWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold,  CostAndPrices.CAP.ReinfMediumFighterGold) == true) {
//
//					GameControl.control.Gold -=  CostAndPrices.CAP.ReinfMediumFighterGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		case AssaultTeam.AT_Types.Heavy_Fighter:
//			if (ats.isGold.isOn == false) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfHeavyFighterWarfunds) == true) {
//
//					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfHeavyFighterWarfunds;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			} else if (ats.isGold.isOn == true) {
//				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfHeavyFighterGold) == true) {
//
//					GameControl.control.Gold -= CostAndPrices.CAP.ReinfHeavyFighterGold;
//				}else {
//					ats.isDeployed.isOn = false;
//					ats.active = false;
//					at.IsDeployed = false;
//					at.readyForDeploy = false;
//					return;
//				}
//
//			}
//			break;
//		}
//
//		if(istes == true){
//			//active(c, at, id, ats);
//		}else if(istes== false){
//			if (at.Owner_ID == id){
//				//nactive(c, at, id, ats);
//				Debug.LogError ("ATManager: Matching ");
//
//			}else {
//				ats.isDeployed.isOn = true; 
//				return;
//			}
//
//		}
//
//		ATmanager.atManager.ShowInfoAndAt (c, id);
//
//	}

//	public void active(Character c, AssaultTeam at, int id, ATHolder ats ){//int Costs, bool _isGold
//		if (c.CommandActivePoints == 0) {
//			return;
//		}
//		DeployAT (c.Faction.ToString(), id, c, at, ats);
//		Debug.LogError ("active()");
//
//		//Debug.LogError ("ATManager: Deploy the at " + at.Tag + "-" + at.ViewerID + "-" + at.Owner_ID + at.AT_Name + " Price: " + dd.Costs.ToString());
//	}


//	void nactive(Character c, AssaultTeam at, int id, ATHolder ats){
//		Debug.LogError ("nactive");
//		ats.active = false;
//		Debug.LogError ("ATManager: hold is que");
//		at.IsDeployed = false;
//		at.Owner_ID = 0;
//		c.CommandActivePoints += at.CommandPoints;
//		at.IsActive = false;
//		if(c.Faction.ToString() == "US"){
//			if(GameControl.control.USdeployed.Count == 0){return;}
//			GameControl.control.USdeployed.Remove (at.AT_Name);
//		}else if(c.Faction.ToString() == "GERMANY"){
//			if(GameControl.control.GERMdeployed.Count == 0){return;}
//			GameControl.control.GERMdeployed.Remove (at.AT_Name);
//		}else if(c.Faction.ToString() == "SOVIET"){
//			if(GameControl.control.SOVdeployed.Count == 0){return;}
//			GameControl.control.SOVdeployed.Remove (at.AT_Name);
//		}
//
//		foreach (KeyValuePair<int, Deploydata> t in FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed) {
//			if (t.Value.DeployID == c.C_DeployID) {
//
//				if(FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Count == 0){
//					//ShowAT (c.Faction.ToString ());
//					return;}
//				//ShowInfoAndAt (c, id);
//				ATmanager.atManager.ResetPanel (ATmanager.atManager.AT);
//				FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Remove (t.Key);
//
//
//			}
//		}
//		//FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Remove (c.C_DeployID);
//		//ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => ShowAT(c.Faction.ToString()));
//
//	}
	// Change the code to new DeployData class
//	public void shDeploy(Character chc){
//		Debug.LogError ("shDeploy");
//		ATmanager.atManager.ResetPanel (deployview);
//		Character ch = chc;
//		//		Debug.LogError ("chc.AssaultTeamsDeployed.Count = " + chc.Type.ToString());
//		//		if (FactionManager.control.Factions [chc.Faction.ToString ()].AssaultTeamsdeployed.Count == 0 || chc.AssaultTeamsDeployed == null) {
//		//			Debug.LogError ("No List found");
//		//			//return;
//		//		} 
//		foreach(KeyValuePair<int, Deploydata> t in FactionManager.control.Factions [chc.Faction.ToString ()].AssaultTeamsdeployed){
//
//			if(t.Value.DeployID == chc.C_DeployID){
//				ATHolder ats = Instantiate (ATmanager.atManager.atPrefab) as ATHolder;
//				ats.transform.SetParent (ATmanager.atManager.AT.transform);
//				ats.GetComponent<ATHolder> ().Name.text = t.Value.assaultTeam.AT_Name;
//				ats.GetComponent<ATHolder> ().img.texture = t.Value.assaultTeam.AT_icon;
//				ats.active = false;
//				//ats.gameObject.GetComponent<Button> ().onClick.AddListener (() => ResetPanel (modifypanel));
//				//ats.gameObject.GetComponent<Button> ().onClick.AddListener (() => shAT (t.Value, chc));
//				//ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => SetReadyForDeploy(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t.Value.assaultTeam, chc.C_DeployID, ats));
//				//ats.GetComponent<ATHolder> ().isDeployed.gameObject.SetActive (false);
//
//
//			}
//
//		}
//		//
//
//	}

	#region couning

	// get the number of characters
	public int GetUSCharacters(){
		return us.Characters.Count;
	}

	public int GetGERMANCharacters(){
		return germ.Characters.Count;
	}

	public int GetSOVIETCharacters(){
		return sov.Characters.Count;
	}


	// Get the number of deployed assault teams
	public int GetUSDeployed(){
		return us.AssaultTeamsdeployed.Count;
	}

	public int GetGERMANDeployed(){
		return germ.AssaultTeamsdeployed.Count;
	}

	public int GetSOVIETDeployed(){
		return sov.AssaultTeamsdeployed.Count;
	}
	#endregion
	// test stuf remove when done
//	void test(){
//		for (int i = 0; i < us.AssaultTeamsdeployed.Count; i++){
//			
//			//us.AssaultTeamsdeployed[i].character.CommandActivePoints = 
//			for (int j = 0; j < us.Characters.Count; j++) {
//				if(us.Characters[j].C_DeployID ==  us.AssaultTeamsdeployed [i].DeployID){
//				us.Characters [j].CommandActivePoints = us.AssaultTeamsdeployed[i].character.CommandActivePoints;
//					Debug.LogError ("testers " + us.Characters [j].CommandActivePoints);
//				}
//			}
//		}
//	}
	#region deploySystem
//////// new DeploySystem 04/06/2017

	public void SetReady(bool istes, Character c, AssaultTeam at, int id, ATHolder ats){
		Debug.Log ("SetReady " + istes);
		if (istes == true) {
			//ats.isDeployed.isOn = true;
//			at.IsActive = true;
//			at.IsDeployed = true;
			StartDeploy(c, at, ats);

		} else if (istes == false) {
			//SetNotReady(c, at);
		} 
	}

	void SetReady(Character c, AssaultTeam at){
		Debug.LogError ("SetReady");
		at.IsActive = true;
		at.setForDeploy = true;
		at.Owner_ID = c.C_DeployID;
		at.ViewerID = c.C_DeployID;
		at.deployID = c.C_DeployID;
		//at.CharPanel.active = at.IsActive;
	}

	void SetNotReady(Character c, AssaultTeam at){
		Debug.LogError ("SetNotReady");
		at.setForDeploy = false;
		at.readyForDeploy = false;
		at.IsDeployed = false;
		at.IsActive = false;
		at.Owner_ID = 0;
		at.ViewerID = 0;
		at.deployID = 0;
	}

//	public void CheckReady(string sfact){
//		Debug.LogError ("Ceckready");
//		if(FactionManager.control.Factions [sfact].AssaultTeams.Count <= 0){Debug.LogError ("no assault teams found"); return;}
//		for (int i = 0; i < FactionManager.control.Factions [sfact].AssaultTeams.Count; i++) {
//			if (FactionManager.control.Factions [sfact].AssaultTeams [i].setForDeploy == true) {
//				FactionManager.control.Factions [sfact].AssaultTeams [i].setForDeploy = false;
//				FactionManager.control.Factions [sfact].AssaultTeams [i].readyForDeploy = true;
//				CreateDeployData (sfact);
//			}
//		}
//	}

//	public void CreateDeployData(string sfact){
//		Debug.LogError ("CreateDeployData");
//		ATHolder ats = Instantiate(ATmanager.atManager.atPrefab) as ATHolder;
//		foreach(Character c in FactionManager.control.Factions[sfact].Characters){
//			
//			foreach(AssaultTeam at in FactionManager.control.Factions[sfact].AssaultTeams){
//				if(at.readyForDeploy == true && c.C_DeployID == at.deployID){
//					Debug.LogError ("create the deploy");
//					//DeployAT (sfact, c.C_DeployID, c, at, ats);
//				}
//
//			}
//		}


//	}

	#region deploying
//	public void DeployAT(string sfact, int id, Character c, AssaultTeam at, ATHolder ats){
//		Debug.LogError ("DeployAT()");
//		if(ats == null){
//			ats = at.CharPanel;
//		}
//
//		int tmpCount = WarManager.WM.DeployCounter++;
//		//		Deploydata dd = new Deploydata (c.C_DeployID, c, at, true);
//		//		// adapt all code and adjust the files
//		//		//at.Owner_ID = c.C_DeployID;
//		//		//c.AssaultTeamsDeployed.Add(at);
//		//		FactionManager.control.Factions [sfact].AssaultTeamsdeployed.Add (tmpCount, dd);
//		//////////////
//		at.IsDeployed = true;
//		at.Owner_ID = c.C_DeployID;
//		c.CommandActivePoints -= at.CommandPoints;
//		at.IsActive = true;
//
//		Deploydata dd = new Deploydata (c.C_DeployID, c, at, false);
//		dd.activeCommandPoints = c.CommandActivePoints;
//		FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Add (tmpCount, dd);
//		//ats.active = true;
////		if(at.IsDeployed == true){
////			if(c.Faction.ToString() == "US"){
////				c.AssaultTeamsDeployed.Add (at.AT_ID);
////				GameControl.control.USdeployed.Add (at.AT_Name, c.C_DeployID);
////			}else if(c.Faction.ToString() == "GERMANY"){
////				c.AssaultTeamsDeployed.Add (at.AT_ID);
////				GameControl.control.GERMdeployed.Add (at.AT_Name, c.C_DeployID);
////			}else if(c.Faction.ToString() == "SOVIET"){
////				c.AssaultTeamsDeployed.Add (at.AT_ID);
////				GameControl.control.SOVdeployed.Add (at.AT_Name, c.C_DeployID);
////			}
////		}
//		//ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => ATmanager.atManager.ShowAT(c.Faction.ToString()));
//	}

	#endregion

	#endregion


	/// redo system 08/06/2017
	/// 
	public void ShowDeployed(string sfact){
		ATmanager.atManager.AT.gameObject.SetActive (false);
		deployview.gameObject.SetActive (true);
		DeploySystem.DS.deploygroup.SetActive (true);
		ATmanager.atManager.ResetPanel (deployview);

		foreach(KeyValuePair<int, Deploydata> dd in FactionManager.control.Factions[sfact].AssaultTeamsdeployed){
			ATHolder ats = Instantiate (ATmanager.atManager.DeployPrefab) as ATHolder;
			ats.active = false;
			ats.isDeployed.isOn = false;

			ats.DeployView = true;
			ats.transform.SetParent (deployview.transform);
			foreach(AssaultTeam at in FactionManager.control.Factions[sfact].AssaultTeams){
				if(dd.Value.name == at.AT_Name){
					
					ats.GetComponent<ATHolder> ().Name.text = at.AT_Name;
					ats.GetComponent<ATHolder> ().img.texture = at.AT_icon;
				}

			}
		}


	}

	void checkCommandPoints(Character c, AssaultTeam at){
		Debug.LogError ("checkCommandPoints");
		if(c.CommandActivePoints <= 0){
			return;
		}

		if(at.CommandPoints > c.CommandActivePoints){
			return;
		}

	}

	public void StartDeploy(Character c, AssaultTeam at, ATHolder ats){
		Debug.LogError ("StartDeploy");
		if(GameControl.control.IsSaved == true){
			
			LoadDeploy (c.Faction.ToString(), c, at);
		}else if(GameControl.control.IsSaved == false){
			checkCommandPoints (c, at);
			CheckWallet (c, at, ats);


			SetReady (c, at);
			ATmanager.atManager.ShowInfoAndAt (c, c.C_ID);
		}else{
			return;
		}
	}

	void CheckWallet(Character c, AssaultTeam at, ATHolder ats){
		Debug.LogError ("CheckWallet");
		switch(at.AT_Type){
		case AssaultTeam.AT_Types.Guard:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfGuardWarfunds) == true) {
					//Debug.LogError ("switch check true");
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfGuardWarfunds;
					
				} else {
					//Debug.LogError ("switch check false");
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfGuardGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfGuardGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					////SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Motorized_Guard:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorGuardWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorGuardWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					////SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorGuardGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorGuardGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					////SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Infantry:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfInfantryWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfInfantryWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					////SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfInfantryGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfInfantryGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					////SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Motorized_Infantry:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorInfantryWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorInfantryWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorInfantryGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorInfantryGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Mechanized_Infantry:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfoMechInfantryWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfoMechInfantryWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMechInfantryGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMechInfantryGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Recon:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfReconWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfReconWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfReconGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfReconGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Motorized_Recon:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMotorReconWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMotorReconWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMotorReconGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMotorReconGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Mechanized_Recon:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMechReconWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMechReconWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMechReconGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMechReconGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Light_Armor:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfLightArmorWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfLightArmorWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfPLightArmorGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfPLightArmorGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Medium_Armor:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMediumArmorWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMediumArmorWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfMediumArmorGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfMediumArmorGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.MediumTankDestroyer:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfTankDestroyerWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfTankDestroyerWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfTankDestroyerGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfTankDestroyerGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Heavy_Armor:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfHeavyArmorWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfHeavyArmorWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfHeavyArmorGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfHeavyArmorGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Pathfinders:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfathfinderWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfathfinderWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfPathfinderGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfPathfinderGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Paratroopers:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfParatrooperWF) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfParatrooperWF;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold,  CostAndPrices.CAP.ReinfParatrooperGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -=  CostAndPrices.CAP.ReinfParatrooperGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Fighter_Recon:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfReconFighterWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfReconFighterWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfReconFighterGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfReconFighterGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Fighter_Squadron:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfMediumFightersWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfMediumFightersWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold,  CostAndPrices.CAP.ReinfMediumFighterGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -=  CostAndPrices.CAP.ReinfMediumFighterGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		case AssaultTeam.AT_Types.Heavy_Fighter:
			if (ats.isGold.isOn == false) {
				if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.ReinfHeavyFighterWarfunds) == true) {
					//SetReady(c, at);
					GameControl.control.Warfunds -= CostAndPrices.CAP.ReinfHeavyFighterWarfunds;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			} else if (ats.isGold.isOn == true) {
				if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.ReinfHeavyFighterGold) == true) {
					//SetReady(c, at);
					GameControl.control.Gold -= CostAndPrices.CAP.ReinfHeavyFighterGold;
				}else {
					ats.isDeployed.isOn = false;
					ats.active = false;
					//SetNotReady(c, at);
					return;
				}

			}
			break;
		}

		c.CommandActivePoints -= at.CommandPoints;
		c.hasDeploy = true;
		ats.isDeployed.isOn = true;
		at.IsActive = true;
		at.IsDeployed = true;
		NewDeploy (at.Faction.ToString(), c, at);
	}

	public void NewDeploy(string sfact, Character c, AssaultTeam at){
		Debug.LogError ("NewDeploy");
		int tmpCount = WarManager.WM.DeployCounter++;
		//character
		c.hasDeploy = true;
		c.hasSavedDeploy = false;

		//assaultteam
		at.deployID = c.C_DeployID;
		at.Owner_ID = c.C_DeployID;
		at.ViewerID = c.C_DeployID;
		at.readyForDeploy = false;
		at.setForDeploy = false;
		at.IsDeployed = true;
		at.IsActive = true;

		if(at.IsDeployed == true){
						if(c.Faction.ToString() == "US"){
							
							GameControl.control.USdeployed.Add (at.AT_Name, c.C_DeployID);
						}else if(c.Faction.ToString() == "GERMANY"){
							
							GameControl.control.GERMdeployed.Add (at.AT_Name, c.C_DeployID);
						}else if(c.Faction.ToString() == "SOVIET"){
							
							GameControl.control.SOVdeployed.Add (at.AT_Name, c.C_DeployID);
						}
					}

		Deploydata dd = new Deploydata (at.AT_Name, sfact, c.C_DeployID, at.deployID, at.Owner_ID, at.ViewerID, c.hasSavedDeploy, c.hasDeploy, c.CommandActivePoints, at.CommandPoints, at.IsActive, at.setForDeploy, at.readyForDeploy, at.IsDeployed, at.IsSavedAndDeployed);
		FactionManager.control.Factions [sfact].AssaultTeamsdeployed.Add (tmpCount, dd);
	}

	public void LoadDeploy(string _faction, Character c, AssaultTeam at){
		c.hasDeploy = true;
		c.hasSavedDeploy = false;
		Debug.LogError ("LoadDeploy");
	}

	public void SaveDeploy(string _faction, Character c, AssaultTeam at){
		c.hasDeploy = false;
		c.hasSavedDeploy = true;
		Debug.LogError ("SaveDeploy");
	}
}
