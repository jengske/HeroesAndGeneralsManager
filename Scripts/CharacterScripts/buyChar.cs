using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

/// <ToDo>
/// Counters needs to be moved to price section buycredid = done only buy gold
/// </ToDo>

public class buyChar : MonoBehaviour {
	public Text _Name;
	public InputField _IName;
	public Dropdown _Faction;
	public Dropdown _Rank;
	public Dropdown _Career;


	// Display selected
	public Text costsCred;
	public Text costsGold;

	// buttons
	public Button creds;
	public Button gold;
	public Button close;

	void Start(){
		_Faction.ClearOptions ();
		List<string> factStr= new List<string>();
		foreach (KeyValuePair<string, Faction> f in FactionManager.control.Factions) {
			factStr.Add (f.Key);
		}

		_Faction.AddOptions (factStr);

		_Rank.ClearOptions ();
		List<string> rankstr = new List<string> ();
		rankstr.Add ("Private");
		rankstr.Add ("SecondLieutenant");
		rankstr.Add ("Major");
		rankstr.Add ("BrigadierGeneral");

		_Rank.AddOptions (rankstr);

		_Career.ClearOptions ();
		List<string> careerstr = new List<string> ();
		careerstr.Add ("Infantry");
		careerstr.Add ("Para");
		careerstr.Add ("Recon");
		careerstr.Add ("Tanker");
		careerstr.Add ("Pilot");
		careerstr.Add ("General");

		_Career.AddOptions (careerstr);

//		creds.onClick.AddListener (() => buyCharCredit());
//		gold.onClick.AddListener (() => buyCharGold());
//		close.onClick.AddListener (() => DestroyObj(this.gameObject));
	}

	public void DestroyObj(GameObject go){
		Destroy (go);
		CharacterManager.characterManager.buyPanel.gameObject.SetActive (false);
	}

	public void buyCharCredit(){
		Debug.LogError ("buyc start");
		if (_IName.text == ""){Debug.LogError ("buyCharCredit: nothing filled in"); return;}

		Character newCredit = null;

		if(_Career.captionText.text == "Infantry"){
			newCredit = new Infantry (_Faction.captionText.text);
			CharacterManager.characterManager.CharCount++;
			newCredit.C_DeployID = CharacterManager.characterManager.CharCount;

			Debug.LogError ("set inf");
		}else if(_Career.captionText.text == "Para"){
			newCredit = new Para (_Faction.captionText.text);

			Debug.LogError ("set para");
		}else if(_Career.captionText.text == "Recon"){
			newCredit = new Recon (_Faction.captionText.text);
			CharacterManager.characterManager.CharCount++;
			newCredit.C_DeployID = CharacterManager.characterManager.CharCount;

			Debug.LogError ("set recon");
		}else if(_Career.captionText.text == "Tanker"){
			newCredit = new Tankman (_Faction.captionText.text);
			CharacterManager.characterManager.CharCount++;
			newCredit.C_DeployID = CharacterManager.characterManager.CharCount;

			Debug.LogError ("set tanker");
		}else if(_Career.captionText.text == "Pilot"){
			newCredit = new Pilot (_Faction.captionText.text);
			CharacterManager.characterManager.CharCount++;
			newCredit.C_DeployID = CharacterManager.characterManager.CharCount;

			Debug.LogError ("set pilot");
		}else if(_Career.captionText.text == "General"){
			newCredit = new General (_Faction.captionText.text);
			CharacterManager.characterManager.CharCount++;
			newCredit.C_DeployID = CharacterManager.characterManager.CharCount;
			newCredit.Rank = Character.C_Rank.BrigadierGeneral;

			Debug.LogError ("set general");
		}

		newCredit.C_Name = _IName.text;
		newCredit.CharPanel = CharacterManager.characterManager.CharacterPrefab;
		newCredit.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + _Faction.captionText.text);
		//newCredit.AssaultTeamsDeployed = new List<AssaultTeam> ();
		Debug.LogError ("set rank");
			switch (_Rank.captionText.text) {
			case "Private":
				//Debug.Log ("switch: rank private");
				newCredit.Rank = Character.C_Rank.Private;
				newCredit.setRankIcon (_Faction.captionText.text);

				break;
		case "SecondLieutenant":
			//Debug.Log ("switch: rank SecondLieutenant");
			newCredit.Rank = Character.C_Rank.SecondLieutenant;
			newCredit.setRankIcon (_Faction.captionText.text);
			newCredit.setCommandPoints();

				break;
			case "Major":
				//Debug.Log ("switch: rank Major");
				newCredit.Rank = Character.C_Rank.Major;
				newCredit.setRankIcon (_Faction.captionText.text);
				newCredit.setCommandPoints();

				break;
			case "BrigadierGeneral":
				//Debug.Log ("switch: rank BrigadierGeneral");
				newCredit.Rank = Character.C_Rank.BrigadierGeneral;
				newCredit.Type = Character.C_Type.General;
				newCredit.setRankIcon (_Faction.captionText.text);
				newCredit.setCommandPoints();
				break;

			}
		if (_Career.captionText.text == "General") {
			newCredit.Rank = Character.C_Rank.BrigadierGeneral;
			newCredit.setRankIcon (_Faction.captionText.text);
		} 

		newCredit.RankIcon = FactionManager.control.getRankIcon(newCredit.Rank.ToString());
		Debug.LogError ("set price");
		if (newCredit.Type == Character.C_Type.InfantryMan && newCredit.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyPrivateInfCred) {
				return;
			} else {
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyPrivateInfCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharInf += 1;
			}

		} else if (newCredit.Type == Character.C_Type.InfantryMan && newCredit.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Credits < CostAndPrices.CAP.Buy2ndLutInfCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.Buy2ndLutInfCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.Buy2ndLutInfCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharInf += 1;
			}

		} else if (newCredit.Type == Character.C_Type.InfantryMan && newCredit.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyMajorInfCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyMajorInfCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyMajorInfCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharInf += 1;
			}

			// Para
		} else if (newCredit.Type == Character.C_Type.Para && newCredit.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyPrivateParaCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyPrivateParaCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyPrivateParaCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPar += 1;
			}

		} else if (newCredit.Type == Character.C_Type.Para && newCredit.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Credits < CostAndPrices.CAP.Buy2ndLutParaCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.Buy2ndLutParaCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.Buy2ndLutParaCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPar += 1;
			}

		} else if (newCredit.Type == Character.C_Type.Para && newCredit.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyMajorParaCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyMajorParaCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyMajorParaCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPar += 1;
			}
			//Recon
		} else if (newCredit.Type == Character.C_Type.Recon && newCredit.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyPrivateReconCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyPrivateReconCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyPrivateReconCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharRec += 1;
			}

		} else if (newCredit.Type == Character.C_Type.Recon && newCredit.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Credits < CostAndPrices.CAP.Buy2ndLutReconCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.Buy2ndLutReconCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.Buy2ndLutReconCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharRec += 1;

			}

		} else if (newCredit.Type == Character.C_Type.Recon && newCredit.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyMajorReconCred) {
				//_Faction.captionText.text = "";
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyMajorReconCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyMajorReconCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharRec += 1;

			}

			// Tanker
		} else if (newCredit.Type == Character.C_Type.TankMan && newCredit.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyPrivateTankerCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyPrivateTankerCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyPrivateTankerCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharTan += 1;

			}

		} else if (newCredit.Type == Character.C_Type.TankMan && newCredit.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Credits < CostAndPrices.CAP.Buy2ndLutTankerCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.Buy2ndLutTankerCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.Buy2ndLutTankerCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharTan += 1;

			}

		} else if (newCredit.Type == Character.C_Type.TankMan && newCredit.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyMajorTankerCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyMajorTankerCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyMajorTankerCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharTan += 1;

			}

			// Pilot
		} else if (newCredit.Type == Character.C_Type.Pilot && newCredit.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyPrivatePilotCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyPrivatePilotCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyPrivatePilotCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPil += 1;
			}

		} else if (newCredit.Type == Character.C_Type.Pilot && newCredit.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Credits < CostAndPrices.CAP.Buy2ndLutPilotCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.Buy2ndLutPilotCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.Buy2ndLutPilotCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPil += 1;
			}

		} else if (newCredit.Type == Character.C_Type.Pilot && newCredit.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyMajorPilotCred) {
				return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyMajorPilotCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyMajorPilotCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPil += 1;
			}

			// General
		} else if (newCredit.Type == Character.C_Type.General && newCredit.Rank == Character.C_Rank.BrigadierGeneral) {
			Debug.LogError ("general, brigadier");
			if (GameControl.control.Credits < CostAndPrices.CAP.BuyGeneralCred) {
				//Debug.LogError ("general, brigadier = not ok to buy");
				//return;
			} else {
				//costsCred.text = CostAndPrices.CAP.BuyGeneralCred.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newCredit);
				GameControl.control.Credits -= CostAndPrices.CAP.BuyGeneralCred;
				FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharGen += 1;
				//Debug.LogError ("general, brigadier = ok to buy");
			}
		}
		//FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedChar += 1;
		//Debug.LogError ("buyc end id = " + newCredit.C_ID.ToString());
		//Debug.LogError ("Character section: id check = " + newCredit.C_ID.ToString());

	}

	public void buyCharGold(){
		if (_IName.text == ""){Debug.LogError ("buyCharGold: nothing filled in"); return;}
		Character newGold = null;

		if(_Career.captionText.text == "Infantry"){
			newGold = new Infantry (_Faction.captionText.text);
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharInf += 1;
			//Debug.Log ("db check: " + newGold.AssaultTeamsDeployed);

		}else if(_Career.captionText.text == "Para"){
			newGold = new Para (_Faction.captionText.text);
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPar += 1;


		}else if(_Career.captionText.text == "Recon"){
			newGold = new Recon (_Faction.captionText.text);
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharRec += 1;


		}else if(_Career.captionText.text == "Tanker"){
			newGold = new Tankman (_Faction.captionText.text);
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharTan += 1;


		}else if(_Career.captionText.text == "Pilot"){
			newGold = new Pilot (_Faction.captionText.text);
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharPil += 1;


		}else if(_Career.captionText.text == "General"){
			newGold = new General (_Faction.captionText.text);
			newGold.Rank = Character.C_Rank.BrigadierGeneral;
			FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedCharGen += 1;


		}
		CharacterManager.characterManager.CharCount++;
		newGold.C_DeployID = CharacterManager.characterManager.CharCount;
		newGold.C_Name = _IName.text;
		newGold.CharPanel = CharacterManager.characterManager.CharacterPrefab;
		newGold.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + _Faction.captionText.text);
		//newGold.AssaultTeamsDeployed = new List<AssaultTeam> ();

			switch (_Rank.captionText.text) {
			case "Private":
				//Debug.Log ("switch: rank private");
				newGold.Rank = Character.C_Rank.Private;
				newGold.setRankIcon (_Faction.captionText.text);

				break;
		case "SecondLieutenant":
			//Debug.Log ("switch: rank SecondLieutenant");
			newGold.Rank = Character.C_Rank.SecondLieutenant;
			newGold.setRankIcon (_Faction.captionText.text);
			newGold.setCommandPoints ();

				break;
			case "Major":
				//Debug.Log ("switch: rank Major");
				newGold.Rank = Character.C_Rank.Major;
				newGold.setRankIcon (_Faction.captionText.text);
				newGold.setCommandPoints ();

				break;
			case "BrigadierGeneral":
				//Debug.Log ("switch: rank BrigadierGeneral");
				newGold.Rank = Character.C_Rank.BrigadierGeneral;
				newGold.Type = Character.C_Type.General;
				newGold.setRankIcon (_Faction.captionText.text);
				newGold.setCommandPoints ();
				break;

			}
		if (_Career.captionText.text == "General") {
			newGold.Rank = Character.C_Rank.BrigadierGeneral;
			newGold.setRankIcon (_Faction.captionText.text);
			newGold.setCommandPoints ();
		} 

		newGold.RankIcon = FactionManager.control.getRankIcon(newGold.Rank.ToString());

		if (newGold.Type == Character.C_Type.InfantryMan && newGold.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyPrivateInfGold) {
				return;
			} else {
				GameControl.control.Gold -= CostAndPrices.CAP.BuyPrivateInfGold;
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				costsGold.text = CostAndPrices.CAP.BuyPrivateInfGold.ToString ();
			}

		} else if (newGold.Type == Character.C_Type.InfantryMan && newGold.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Gold < CostAndPrices.CAP.Buy2ndLutInfGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.Buy2ndLutInfGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.Buy2ndLutInfGold;
			}

		} else if (newGold.Type == Character.C_Type.InfantryMan && newGold.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyMajorInfGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyMajorInfGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyMajorInfGold;
			}

			// Para
		} else if (newGold.Type == Character.C_Type.Para && newGold.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyPrivateParaGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyPrivateParaGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyPrivateParaGold;
			}

		} else if (newGold.Type == Character.C_Type.Para && newGold.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Gold < CostAndPrices.CAP.Buy2ndLutParaGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.Buy2ndLutParaGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.Buy2ndLutParaGold;
			}

		} else if (newGold.Type == Character.C_Type.Para && newGold.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyMajorParaGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyMajorParaGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyMajorParaGold;
			}
			//Recon
		} else if (newGold.Type == Character.C_Type.Recon && newGold.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyPrivateReconGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyPrivateReconGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyPrivateReconGold;
			}

		} else if (newGold.Type == Character.C_Type.Recon && newGold.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Gold < CostAndPrices.CAP.Buy2ndLutReconGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.Buy2ndLutReconGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.Buy2ndLutReconGold;
			}

		} else if (newGold.Type == Character.C_Type.Recon && newGold.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyMajorReconGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyMajorReconGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyMajorReconGold;
			}

			// Tanker
		} else if (newGold.Type == Character.C_Type.TankMan && newGold.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyPrivateTankerGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyPrivateTankerGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyPrivateTankerGold;
			}

		} else if (newGold.Type == Character.C_Type.TankMan && newGold.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Gold < CostAndPrices.CAP.Buy2ndLutTankerGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.Buy2ndLutTankerGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.Buy2ndLutTankerGold;
			}

		} else if (newGold.Type == Character.C_Type.TankMan && newGold.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyMajorTankerGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyMajorTankerGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyMajorTankerGold;
			}

			// Pilot
		} else if (newGold.Type == Character.C_Type.Pilot && newGold.Rank == Character.C_Rank.Private) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyPrivatePilotGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyPrivatePilotGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyPrivatePilotGold;
			}

		} else if (newGold.Type == Character.C_Type.Pilot && newGold.Rank == Character.C_Rank.SecondLieutenant) {
			if (GameControl.control.Gold < CostAndPrices.CAP.Buy2ndLutPilotGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.Buy2ndLutPilotGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.Buy2ndLutPilotGold;
			}

		} else if (newGold.Type == Character.C_Type.Pilot && newGold.Rank == Character.C_Rank.Major) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyMajorPilotGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyMajorPilotGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyMajorPilotGold;
			}

			// General
		} else if (newGold.Type == Character.C_Type.General && newGold.Rank == Character.C_Rank.BrigadierGeneral) {
			if (GameControl.control.Gold < CostAndPrices.CAP.BuyGeneralGold) {
				return;
			} else {
				costsGold.text = CostAndPrices.CAP.BuyGeneralGold.ToString (); 
				FactionManager.control.Factions [_Faction.captionText.text].Characters.Add (newGold);
				GameControl.control.Gold -= CostAndPrices.CAP.BuyGeneralGold;
			}
		}



		//FactionManager.control.Factions [_Faction.captionText.text].TotalOwnedChar += 1;
		//Debug.LogError (FactionManager.control.Factions [_Faction.captionText.text].Characters.Count);
	}

	void Update(){
		if (_Career.captionText.text == "Infantry" && _Rank.captionText.text == "Private") {
			
			costsCred.text = CostAndPrices.CAP.BuyPrivateInfCred.ToString ();
			costsGold.text = CostAndPrices.CAP.BuyPrivateInfGold.ToString ();


		} else if (_Career.captionText.text == "Infantry" && _Rank.captionText.text == "SecondLieutenant") {
			
			costsCred.text = CostAndPrices.CAP.Buy2ndLutInfCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.Buy2ndLutInfGold.ToString ();
				

		} else if (_Career.captionText.text == "Infantry" && _Rank.captionText.text == "Major") {
			
			costsCred.text = CostAndPrices.CAP.BuyMajorInfCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyMajorInfGold.ToString (); 
				

			// Para
		} else if (_Career.captionText.text == "Para" && _Rank.captionText.text == "Private") {
			costsCred.text = CostAndPrices.CAP.BuyPrivateParaCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyPrivateParaGold.ToString ();
		

		} else if (_Career.captionText.text == "Para" && _Rank.captionText.text == "SecondLieutenant") {

			costsCred.text = CostAndPrices.CAP.Buy2ndLutParaCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.Buy2ndLutParaGold.ToString (); 
		} else if (_Career.captionText.text == "Para" && _Rank.captionText.text == "Major") {
			costsCred.text = CostAndPrices.CAP.BuyMajorParaCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyMajorParaGold.ToString ();
		
			//Recon
		} else if (_Career.captionText.text == "Recon" && _Rank.captionText.text == "Private") {
			costsCred.text = CostAndPrices.CAP.BuyPrivateReconCred.ToString ();
			costsGold.text = CostAndPrices.CAP.BuyPrivateReconGold.ToString ();
			

		} else if (_Career.captionText.text == "Recon" && _Rank.captionText.text == "SecondLieutenant") {
			costsCred.text = CostAndPrices.CAP.Buy2ndLutReconCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.Buy2ndLutReconGold.ToString ();


		} else if (_Career.captionText.text == "Recon" && _Rank.captionText.text == "Major") {
			costsCred.text = CostAndPrices.CAP.BuyMajorReconCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyMajorReconGold.ToString ();
		
			// Tanker
		} else if (_Career.captionText.text == "TankMan" && _Rank.captionText.text == "Private") {
			costsCred.text = CostAndPrices.CAP.BuyPrivateTankerCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyPrivateTankerGold.ToString ();
			

		} else if (_Career.captionText.text == "TankMan" && _Rank.captionText.text == "SecondLieutenant") {
			costsCred.text = CostAndPrices.CAP.Buy2ndLutTankerCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.Buy2ndLutTankerGold.ToString ();
			

		} else if (_Career.captionText.text == "TankMan" && _Rank.captionText.text == "Major") {
			
			costsCred.text = CostAndPrices.CAP.BuyMajorTankerCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.BuyMajorTankerGold.ToString (); 
			

			// Pilot
		} else if (_Career.captionText.text == "Pilot" && _Rank.captionText.text == "Private") {

			costsCred.text = CostAndPrices.CAP.BuyPrivatePilotCred.ToString ();
			costsGold.text = CostAndPrices.CAP.BuyPrivatePilotGold.ToString ();
			

		} else if (_Career.captionText.text == "Pilot" && _Rank.captionText.text == "SecondLieutenant") {
			
			costsCred.text = CostAndPrices.CAP.Buy2ndLutPilotCred.ToString (); 
			costsGold.text = CostAndPrices.CAP.Buy2ndLutPilotGold.ToString (); 

		} else if (_Career.captionText.text == "Pilot" && _Rank.captionText.text == "Major") {
			
			costsCred.text = CostAndPrices.CAP.BuyMajorPilotCred.ToString ();
			costsGold.text = CostAndPrices.CAP.BuyMajorPilotGold.ToString ();

			// General
		} else if (_Career.captionText.text == "General" || _Rank.captionText.text == "BrigadierGeneral") {
			
			costsGold.text = CostAndPrices.CAP.BuyGeneralGold.ToString (); 
			costsCred.text = CostAndPrices.CAP.BuyGeneralCred.ToString (); 

		}
			
	}
}


