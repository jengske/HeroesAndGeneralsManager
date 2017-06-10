using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ATmanager : MonoBehaviour {
	public static ATmanager atManager;
	// Prefabs
	public ATHolder atPrefab;
	public ATHolder DeployPrefab;
	public ATChar charPrefab;

	public BuyAT BuyATs;
	public upgrAT UpgrATs;

	// spawnPanels
	public RectTransform soldiers;
	public RectTransform info;
	public RectTransform AT;
	public RectTransform buypanel;
	public RectTransform modifypanel;

	// buttons
	public Button shDeplo;
	public Button IMGHolder;

	//public Dictionary<string, AssaultTeam> Deployed = new Dictionary<string, AssaultTeam> ();

	void Awake () {
		// only one instance allowed
		if (atManager == null) {
			//DontDestroyOnLoad (gameObject);
			atManager = this;
		} else if (atManager != this) {
			Destroy (gameObject);
		}
	}


	// Use this for initialization
	void Start () {
//		newGuard ("US");
//		newRecon ("US");
//		newHarmor("US");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	#region createassaultteams
	// create new assaultteam types
	// infantry
	public void newGuard(string sfact, int id){
		AssaultTeam guard = new Guard (sfact);
		guard.CharPanel = atPrefab;
		guard.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + guard.AT_ID.ToString() + " " + guard.AT_Type.ToString();
		Debug.Log(string.Format(FactionManager.control.Factions[sfact].Tag, id, guard.AT_Type ));


		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
////				if (ch.AssaultTeamsOwned == null) {
////					ch.AssaultTeamsOwned = new List<AssaultTeam> ();
////				}
////				guard.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (guard);
//			}
		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (guard);
		FactionManager.control.Factions [sfact].TotalGuards += 1;
	}

	public void newMGuard(string sfact, int id){
		AssaultTeam Mguard = new MotorGuard(sfact);
		Mguard.CharPanel = atPrefab;
		Mguard.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Mguard.AT_ID.ToString() + " " + Mguard.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Mguard.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Mguard);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Mguard);
		FactionManager.control.Factions [sfact].TotalMguards += 1;
	}

	public void newInfantry(string sfact, int id){
		AssaultTeam inf = new ATInfantry(sfact);
		inf.CharPanel = atPrefab;
			inf.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + inf.AT_ID.ToString() + " " + inf.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				inf.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (inf);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (inf);
		FactionManager.control.Factions [sfact].TotalInfantry += 1;
	}

	public void newMInfantry(string sfact, int id){
		AssaultTeam Minf = new MotorizedInf(sfact);
		Minf.CharPanel = atPrefab;
		Minf.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Minf.AT_ID.ToString() + " " + Minf.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Minf.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Minf);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Minf);
		FactionManager.control.Factions [sfact].TotalMinfantry += 1;
	}

	public void newMechInfantry(string sfact, int id){
		AssaultTeam Mechinf = new MechInfantry(sfact);
		Mechinf.CharPanel = atPrefab;
		Mechinf.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Mechinf.AT_ID.ToString() + " " + Mechinf.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Mechinf.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Mechinf);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Mechinf);
		FactionManager.control.Factions [sfact].TotalMechInfantry += 1;
	}

	// Recon
	public void newRecon(string sfact, int id){
		AssaultTeam Rec = new ATRecon(sfact);
		Rec.CharPanel = atPrefab;
		Rec.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Rec.AT_ID.ToString() + " " + Rec.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Rec.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Rec);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Rec);
		FactionManager.control.Factions [sfact].TotalRecon += 1;
	}

	public void newMRecon(string sfact, int id){
		AssaultTeam MRec = new MotorRecon(sfact);
		MRec.CharPanel = atPrefab;
		MRec.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + MRec.AT_ID.ToString() + " " + MRec.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				MRec.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (MRec);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (MRec);
		FactionManager.control.Factions [sfact].TotalMrecon += 1;
	}

	public void newMechRecon(string sfact, int id){
		AssaultTeam MechRec = new MechRecon(sfact);
		MechRec.CharPanel = atPrefab;
		MechRec.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + MechRec.AT_ID.ToString() + " " + MechRec.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				MechRec.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (MechRec);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (MechRec);
		FactionManager.control.Factions [sfact].TotalMechRecon += 1;
	}

	// Armor
	public void newLarmor(string sfact, int id){
		AssaultTeam Larm = new LightArmor(sfact);
		Larm.CharPanel = atPrefab;
		Larm.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Larm.AT_ID.ToString() + " " + Larm.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Larm.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Larm);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Larm);
		FactionManager.control.Factions [sfact].TotalLightArmor += 1;
	}

	public void newMarmor(string sfact, int id){
		AssaultTeam Marm = new MediumArmor(sfact);
		Marm.CharPanel = atPrefab;
		Marm.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Marm.AT_ID.ToString() + " " + Marm.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Marm.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Marm);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Marm);
		FactionManager.control.Factions [sfact].TotalMediumArmor += 1;
	}

	public void newHarmor(string sfact, int id){
		AssaultTeam Harm = new HeavyArmor(sfact);
		Harm.CharPanel = atPrefab;
		Harm.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Harm.AT_ID.ToString() + " " + Harm.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Harm.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Harm);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Harm);
		FactionManager.control.Factions [sfact].TotalHeavyArmor += 1;
	}

	public void newTD(string sfact, int id){
		AssaultTeam td = new Destroyers(sfact);
		td.CharPanel = atPrefab;
		td.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + td.AT_ID.ToString() + " " + td.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				td.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (td);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (td);
		FactionManager.control.Factions [sfact].TotalDestroyers += 1;
	}

	// Air

	public void newPathfinder(string sfact, int id){
		AssaultTeam fin = new ATPathfinder(sfact);
		fin.CharPanel = atPrefab;
		fin.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + fin.AT_ID.ToString() + " " + fin.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				fin.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (fin);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (fin);
		FactionManager.control.Factions [sfact].TotalPathfinders += 1;
	}

	public void newParatrooper(string sfact, int id){
		AssaultTeam tro = new ParaTrooper(sfact);
		tro.CharPanel = atPrefab;
		tro.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + tro.AT_ID.ToString() + " " + tro.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				tro.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (tro);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (tro);
		FactionManager.control.Factions [sfact].TotalParatroopers += 1;
	}

	public void newReconFighter(string sfact, int id){
		AssaultTeam onF = new ReconFighter(sfact);
		onF.CharPanel = atPrefab;
		onF.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + onF.AT_ID.ToString() + " " + onF.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				onF.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (onF);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (onF);
		FactionManager.control.Factions [sfact].TotalReconFighters += 1;
	}

	public void newFighterSquadron(string sfact, int id){
		AssaultTeam Squ = new FighterSquadron(sfact);
		Squ.CharPanel = atPrefab;
		Squ.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + Squ.AT_ID.ToString() + " " + Squ.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				Squ.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (Squ);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (Squ);
		FactionManager.control.Factions [sfact].TotalFighterSquadrons += 1;
	}

	public void newHeavyFighterSquadron(string sfact, int id){
		AssaultTeam ron = new HeavyFighterSquadron(sfact);
		ron.CharPanel = atPrefab;
		ron.AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + ron.AT_ID.ToString() + " " + ron.AT_Type.ToString();

//		foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//			if (id == ch.DeployID) {
//				ron.Owner_ID = ch.DeployID;
////				ch.AssaultTeamsOwned.Add (ron);
//			}
//		}

		FactionManager.control.Factions [sfact].AssaultTeams.Add (ron);
		FactionManager.control.Factions [sfact].TotalHeavyFighterSquadrons += 1;
	}

	#endregion createassaultteams

	#region showSoldiers
	public void ShowAT(string sfact){
		// first clean the panel
		ResetAll();

		foreach (Character ch in FactionManager.control.Factions[sfact].Characters) {
			//Debug.Log ("CP: " + ch.CommandPoints.ToString());
			if (ch.CommandPoints >= 0) {
				// display in list
				Character chc = ch;
				//GameObject go = new GameObject ();
				Button go = Instantiate(IMGHolder) as Button;
				go.name = ch.C_Name;
				go.GetComponent<getimage> ().img.texture = ch.C_Image;
//				go.AddComponent<Selectable> ();
				go.onClick.AddListener (() => ShowInfoAndAt(ch, ch.C_DeployID));
				go.transform.SetParent (soldiers.transform);
				}
		}
	}

	#endregion showSoldiers
	// modify and adjust to the faction list not the character
	public void ShowInfoAndAt(Character chc, int id)  {
		DeploySystem.DS.deployview.gameObject.SetActive (false);
		DeploySystem.DS.deploygroup.SetActive (false);
		AT.gameObject.SetActive (true);
		// show the characters that have CommandPoints
		#region infopanel
		ResetPanel(info);
		ResetPanel(AT);
		ResetPanel(buypanel);
		ResetPanel(modifypanel);
		//Debug.Log ("show the character info " + chc.C_Name + " ID: " + chc.C_DeployID.ToString() );
		ATChar har = Instantiate (charPrefab) as ATChar;
		har.transform.SetParent (info.transform);
		har.transform.localPosition = new Vector2 (0.0f, 0.0f);

		har.GetComponent<ATChar> ()._Icon.texture = chc.C_Image;
		har.GetComponent<ATChar> ()._Name.text = chc.C_Name;
		har.GetComponent<ATChar> ()._Rank.text = chc.Rank.ToString ();
		har.GetComponent<ATChar> ()._FactionName.text = chc.Faction.ToString ();
		har.GetComponent<ATChar> ()._Flag.texture = chc.FactionFlag;


		#region buyAT
		// Show the buy buttons per character class (infantry, recon, para, pilot tanker or general)
		// we going to set the buy button on this section also
		if(chc.Type == Character.C_Type.InfantryMan){
			// do stuff
			Debug.LogError("infantry " + chc.Type.ToString());
			har.GetComponent<ATChar> ()._Guard.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Guard.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Guard, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Para.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Recon.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Armor.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Fighters.gameObject.SetActive(false);
		}else if(chc.Type == Character.C_Type.Para){
			// do stuff
			har.GetComponent<ATChar> ()._Guard.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Para.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Para.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Para, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Recon.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Armor.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Fighters.gameObject.SetActive(false);
		}else if(chc.Type == Character.C_Type.Recon){
			// do stuff
			har.GetComponent<ATChar> ()._Guard.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Para.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Recon.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Recon.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Recon, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Armor.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Fighters.gameObject.SetActive(false);
		}else if(chc.Type == Character.C_Type.TankMan){
			// do stuff
			har.GetComponent<ATChar> ()._Guard.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Para.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Recon.gameObject.SetActive(false);
			har.GetComponent<ATChar> ()._Armor.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Armor.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Armor, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Fighters.gameObject.SetActive(false);
		}else if(chc.Type == Character.C_Type.General){
			// do stuff
			har.GetComponent<ATChar> ()._Guard.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Para.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Recon.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Armor.gameObject.SetActive(true);
			har.GetComponent<ATChar> ()._Fighters.gameObject.SetActive(true);

			// all buttons active, we set onClick
			har.GetComponent<ATChar> ()._Guard.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Guard, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Para.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Para, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Recon.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Recon, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Armor.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Armor, chc.Faction.ToString(), chc.C_DeployID, chc));
			har.GetComponent<ATChar> ()._Fighters.onClick.AddListener (() => shBuyAT(har.GetComponent<ATChar> ()._Fighters, chc.Faction.ToString(), chc.C_DeployID, chc));
		}
		#endregion

		foreach (Transform child in har.GetComponent<ATChar> ()._CP.transform) {
			//Debug.Log (child.name);
			child.GetComponent<Image> ().color = Color.gray;

		}
		// show the commandpoints owned on the character
		for(int i = 0; i < chc.CommandActivePoints; i++){
			//child.GetComponent<Image> ().color = Color.white;
			//Debug.Log ("test " + i);
			har.GetComponent<ATChar> ()._CP.transform.GetChild(i).GetComponent<Image> ().color = Color.white;
			Debug.LogError("active commandpoints: " + chc.CommandActivePoints);
		}
		#endregion
		ResetPanel (AT);
		shDeplo.onClick.AddListener(() => DeploySystem.DS.ShowDeployed(GameControl.control.CurrentFaction));
		if (FactionManager.control.Factions[chc.Faction.ToString()].AssaultTeams == null) { //chc.AssaultTeamsDeployed
			return;
		} else {
			ResetPanel(AT);
			foreach(AssaultTeam t in FactionManager.control.Factions[chc.Faction.ToString()].AssaultTeams){ //chc.AssaultTeamsDeployed
				Debug.LogError("IsDeployed: " + t.IsDeployed + " Isactive: " + t.IsActive);
				if (chc.Type == Character.C_Type.InfantryMan) {
					
					if (t.AT_Type == AssaultTeam.AT_Types.Guard || t.AT_Type == AssaultTeam.AT_Types.Motorized_Guard || t.AT_Type == AssaultTeam.AT_Types.Infantry || t.AT_Type == AssaultTeam.AT_Types.Motorized_Infantry || t.AT_Type == AssaultTeam.AT_Types.Mechanized_Infantry) {
						t.ViewerID = chc.C_DeployID;
						ATHolder ats = Instantiate (atPrefab) as ATHolder;
						ats.isDeployed.isOn = t.IsDeployed;
						ats.active = t.IsActive;
						ats.transform.SetParent (AT.transform);
						ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
						ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
						//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
						ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
						//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));
					}
				} else if (chc.Type == Character.C_Type.Recon) {
					
					if (t.AT_Type == AssaultTeam.AT_Types.Recon || t.AT_Type == AssaultTeam.AT_Types.Motorized_Recon || t.AT_Type == AssaultTeam.AT_Types.Mechanized_Recon) {
						t.ViewerID = chc.C_DeployID;
						ATHolder ats = Instantiate (atPrefab) as ATHolder;
						ats.isDeployed.isOn = t.IsDeployed;
						ats.active = t.IsActive;
						ats.transform.SetParent (AT.transform);
						ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
						ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
						//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
						ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
						//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));
					}
				} else if (chc.Type == Character.C_Type.Para) {
					
					if (t.AT_Type == AssaultTeam.AT_Types.Pathfinders || t.AT_Type == AssaultTeam.AT_Types.Paratroopers) {
						t.ViewerID = chc.C_DeployID;
						ATHolder ats = Instantiate (atPrefab) as ATHolder;
						ats.isDeployed.isOn = t.IsDeployed;
						ats.active = t.IsActive;
						ats.transform.SetParent (AT.transform);
						ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
						ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
						//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
						ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
						//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));
					}
				} else if (chc.Type == Character.C_Type.TankMan) {
					
					if (t.AT_Type == AssaultTeam.AT_Types.Light_Armor || t.AT_Type == AssaultTeam.AT_Types.Medium_Armor || t.AT_Type == AssaultTeam.AT_Types.MediumTankDestroyer || t.AT_Type == AssaultTeam.AT_Types.Heavy_Armor) {
						t.ViewerID = chc.C_DeployID;
						ATHolder ats = Instantiate (atPrefab) as ATHolder;
						ats.isDeployed.isOn = t.IsDeployed;
						ats.active = t.IsActive;
						ats.transform.SetParent (AT.transform);
						ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
						ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
						//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
						ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
						//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));
					}
				}else if (chc.Type == Character.C_Type.Pilot) {
					
					if (t.AT_Type == AssaultTeam.AT_Types.Fighter_Recon || t.AT_Type == AssaultTeam.AT_Types.Fighter_Squadron || t.AT_Type == AssaultTeam.AT_Types.Heavy_Fighter) {
						t.ViewerID = chc.C_DeployID;
						ATHolder ats = Instantiate (atPrefab) as ATHolder;
						ats.isDeployed.isOn = t.IsDeployed;
						ats.active = t.IsActive;
						ats.transform.SetParent (AT.transform);
						ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
						ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
						ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
						//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
						ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
						//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));
					}
				}else if (chc.Type == Character.C_Type.General){
					
//				Debug.Log ("get te at owned " + t.Owner_ID + " : "+ t.AT_ID );
				t.ViewerID = chc.C_DeployID;
				ATHolder ats = Instantiate(atPrefab) as ATHolder;
				ats.isDeployed.isOn = t.IsDeployed;
				ats.active = t.IsActive;
				ats.transform.SetParent (AT.transform);
				ats.GetComponent<ATHolder> ().Name.text = t.AT_Name;
				ats.GetComponent<ATHolder> ().img.texture = t.AT_icon;
				ats.gameObject.GetComponent<Button>().onClick.AddListener (() => ResetPanel(modifypanel));
				ats.gameObject.GetComponent<Button>().onClick.AddListener (() => shAT(t, chc));
				//ats.gameObject.GetComponent<Button>().onClick.AddListener (() => Debug.LogError ("ATManager: who selected the at = " + t.ViewerID.ToString ()));
					ats.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => DeploySystem.DS.SetReady(ats.GetComponent<ATHolder> ().isDeployed.isOn, chc, t, chc.C_DeployID, ats));
					//shDeplo.onClick.AddListener(() => DeploySystem.DS.shDeploy(chc));


				}

			}
		}


	}


	public void shBuyAT(Button at, string sfact, int id, Character c){
		ResetPanel (buypanel);

		// only activate the buypanel and set namings + button listners
		BuyAT bt = Instantiate(BuyATs) as BuyAT;
		string tmpname = "";

		bt.transform.SetParent (buypanel.transform);

		if (at.name == "Guard") {
			Debug.LogError ("New Guard set active " + bt._setName.text);
			tmpname = bt._setName.text;	
			bt._DefaultName.text = FactionManager.control.Factions[sfact].Tag + "-" + (Guard.Guardcount + 1 ).ToString() + " Guard";
			bt._icon.texture = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_Guard");

			// buttons
			bt._wfbtn.onClick.AddListener(() => buyWF(CostAndPrices.CAP.BuyGuardWarfunds,sfact, id, at.name, bt, c));

			bt._wftxt.text = CostAndPrices.CAP.BuyGuardWarfunds.ToString();
			bt._gldbtn.onClick.AddListener(() => buyGLD(CostAndPrices.CAP.BuyGuardGold,sfact, id, at.name, bt, c));

			bt._gldtxt.text = CostAndPrices.CAP.BuyGuardGold.ToString();
		}else if (at.name =="Para") {
			bt._DefaultName.text = FactionManager.control.Factions[sfact].Tag + "-" + (ATPathfinder.ATPathfindercount + 1 ).ToString() + " Pathfinder";
			bt._icon.texture = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_Pathfinder");
			tmpname = bt._setName.text;
			bt._wfbtn.onClick.AddListener(() => buyWF(CostAndPrices.CAP.BuyPathfinderWarfunds,sfact, id, at.name, bt, c));
			bt._wftxt.text = CostAndPrices.CAP.BuyPathfinderWarfunds.ToString();
			bt._gldbtn.onClick.AddListener(() => buyGLD(CostAndPrices.CAP.BuyPathfinderGold,sfact, id, at.name, bt, c));
			bt._gldtxt.text = CostAndPrices.CAP.BuyPathfinderGold.ToString();
		}else if (at.name =="Recon") {
			bt._DefaultName.text = FactionManager.control.Factions[sfact].Tag + "-" + (ATRecon.Reconcount + 1 ).ToString() + " Recon";
			bt._icon.texture = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_Recon");
			tmpname = bt._setName.text;
			bt._wfbtn.onClick.AddListener(() => buyWF(CostAndPrices.CAP.BuyReconWarfunds,sfact, id, at.name, bt, c));
			bt._wftxt.text = CostAndPrices.CAP.BuyReconWarfunds.ToString();
			bt._gldbtn.onClick.AddListener(() => buyGLD(CostAndPrices.CAP.BuyReconGold,sfact, id, at.name, bt, c));
			bt._gldtxt.text = CostAndPrices.CAP.BuyReconGold.ToString();
		}else if (at.name =="Armor") {
			bt._DefaultName .text= FactionManager.control.Factions[sfact].Tag + "-" + (LightArmor.LightArmorcount + 1).ToString() + " LightArmor";
			bt._icon.texture = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_Armor");
			tmpname = bt._setName.text;
			bt._wfbtn.onClick.AddListener(() => buyWF(CostAndPrices.CAP.BuyLightArmorWarfunds,sfact, id, at.name, bt, c));
			bt._wftxt.text = CostAndPrices.CAP.BuyLightArmorWarfunds.ToString();
			bt._gldbtn.onClick.AddListener(() => buyGLD(CostAndPrices.CAP.BuyPLightArmorGold,sfact, id, at.name, bt, c));
			bt._gldtxt.text = CostAndPrices.CAP.BuyPLightArmorGold.ToString();
		}else if (at.name =="Fighters") {
			bt._DefaultName.text = FactionManager.control.Factions[sfact].Tag + "-" + (ReconFighter.ReconFightercount + 1).ToString() + " ReconFighter";
			bt._icon.texture = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_FighterSquadron");
			tmpname = bt._setName.text;
			bt._wfbtn.onClick.AddListener(() => buyWF(CostAndPrices.CAP.BuyReconFighterWarfunds,sfact, id, at.name, bt, c));
			bt._wftxt.text = CostAndPrices.CAP.BuyReconFighterWarfunds.ToString();
			bt._gldbtn.onClick.AddListener(() => buyGLD(CostAndPrices.CAP.BuyReconFighterGold,sfact, id, at.name, bt, c));
			bt._gldtxt.text = CostAndPrices.CAP.BuyReconFighterGold.ToString();
		}

	}
		
	public void shAT(AssaultTeam at, Character chc){
		List<string> tmpLst = new List<string> ();
		List<string> addoptions = new List<string> ();

		//foreach (AssaultTeam.AT_Types t in System.Enum.GetValues(typeof(AssaultTeam.AT_Types))) {
			//Debug.Log (t.ToString());
		//}
			//ARMY GUARDS
		if (at.AT_Type == AssaultTeam.AT_Types.Guard) {
			
			addoptions.Add (AssaultTeam.AT_Types.Motorized_Guard.ToString ());
			addoptions.Add (AssaultTeam.AT_Types.Infantry.ToString ());
		}else if (at.AT_Type == AssaultTeam.AT_Types.Motorized_Guard) {

			addoptions.Add (AssaultTeam.AT_Types.Motorized_Infantry.ToString ());

		}else if (at.AT_Type == AssaultTeam.AT_Types.Infantry) {

			addoptions.Add (AssaultTeam.AT_Types.Motorized_Infantry.ToString ());

		}else if (at.AT_Type == AssaultTeam.AT_Types.Motorized_Infantry) {

			addoptions.Add (AssaultTeam.AT_Types.Mechanized_Infantry.ToString ());

		}

		//ARMY RECON
		if (at.AT_Type == AssaultTeam.AT_Types.Recon) {

			addoptions.Add (AssaultTeam.AT_Types.Motorized_Recon.ToString ());

		} else if (at.AT_Type == AssaultTeam.AT_Types.Motorized_Recon) {

			addoptions.Add (AssaultTeam.AT_Types.Mechanized_Recon.ToString ());

		}
		// ARMOR
		if (at.AT_Type == AssaultTeam.AT_Types.Light_Armor) {

			addoptions.Add (AssaultTeam.AT_Types.Medium_Armor.ToString ());
			addoptions.Add (AssaultTeam.AT_Types.MediumTankDestroyer.ToString ());

		} else if (at.AT_Type == AssaultTeam.AT_Types.Medium_Armor) {

			addoptions.Add (AssaultTeam.AT_Types.Heavy_Armor.ToString ());

		}
		// AIR
		if (at.AT_Type == AssaultTeam.AT_Types.Pathfinders) {

			addoptions.Add (AssaultTeam.AT_Types.Paratroopers.ToString ());

		} 
		//AIRF
		if (at.AT_Type == AssaultTeam.AT_Types.Fighter_Recon) {

			addoptions.Add (AssaultTeam.AT_Types.Fighter_Squadron.ToString ());

		} else if (at.AT_Type == AssaultTeam.AT_Types.Fighter_Squadron) {

			addoptions.Add (AssaultTeam.AT_Types.Heavy_Fighter.ToString ());

		}

		upgrAT Upg = Instantiate (UpgrATs) as upgrAT;
		if (at.AT_Type == AssaultTeam.AT_Types.Mechanized_Infantry || at.AT_Type == AssaultTeam.AT_Types.Mechanized_Recon || at.AT_Type == AssaultTeam.AT_Types.MediumTankDestroyer || at.AT_Type == AssaultTeam.AT_Types.Paratroopers || at.AT_Type == AssaultTeam.AT_Types.Heavy_Armor || at.AT_Type == AssaultTeam.AT_Types.Heavy_Fighter) 
		{
			Upg.gld.gameObject.SetActive (false);
			Upg.wf.gameObject.SetActive (false);
			Upg.upgrade.gameObject.SetActive (false);
		}
		// Upgrade assault team
		Upg.upgrade.ClearOptions();
		Upg.upgrade.AddOptions(addoptions);


		Upg.transform.SetParent (modifypanel.transform);
		Upg._Name.text = at.AT_Name;
		Upg._icon.texture = at.AT_icon;
		// rename assault team
		Upg._edit.onClick.AddListener(() => at.Rename(Upg._rename.text));
		Upg._edit.onClick.AddListener(() => Destroy(Upg.gameObject));
		Upg._edit.onClick.AddListener(() => ShowInfoAndAt(chc, chc.C_DeployID));
		// Level up assault team
		Upg.lvltxt.text = at.AT_Level.ToString ();
		Upg.lvlup.onClick.AddListener(() => at.Levelup());
		Upg.lvlup.onClick.AddListener(() => Destroy(Upg.gameObject));
		Upg.lvlup.onClick.AddListener(() => ShowInfoAndAt(chc, chc.C_DeployID));



		// puch button it goes to next code or function
//		Upg.btnWFTxt.text = CostAndPrices.CAP.UgradeToMotorInfantryWF.ToString();
//		Upg.btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMotorInfantryGold.ToString();

		// buttons
		Upg.wf.onClick.AddListener (() => ModifyAT_WF(at, chc.C_DeployID, Upg.upgrade.captionText.text, chc, at.Faction.ToString()));
		//Upg.wf.onClick.AddListener(() => ShowInfoAndAt(chc));
		Upg.gld.onClick.AddListener (() => ModifyAT_GLD(at, chc.C_DeployID, Upg.upgrade.captionText.text, chc, at.Faction.ToString()));
		//Upg.gld.onClick.AddListener(() => ShowInfoAndAt(chc));


	}




	// counters need to be added
	#region modify assault team
	public void ModifyAT_WF(AssaultTeam at, int id, string t, Character c, string sfact){
		// upgrading to
		if (t == "Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToInfantryWF) == true) {
				AssaultTeam IN = new ATInfantry (sfact);
				IN.AT_Name = at.AT_Name;
				IN.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalInfantry += 1;
				FactionManager.control.Factions [sfact].TotalGuards -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToInfantryWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (IN);
				Debug.LogError ("Buyed " + IN.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			} else {
				return;
			}

		}else if (t == "Motorized_Guard") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UpgradeToMotorGuardWF) == true) {
				AssaultTeam MG = new MotorGuard (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMguards += 1;
				FactionManager.control.Factions [sfact].TotalGuards -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UpgradeToMotorGuardWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);	
			}else {
				return;
			}
		
		}else if (t == "Motorized_Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMotorInfantryWF) == true) {
				AssaultTeam MG = new MotorizedInf (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMinfantry += 1;
				if(at.AT_Type == AssaultTeam.AT_Types.Infantry){
					FactionManager.control.Factions [sfact].TotalInfantry -= 1;
				}else if(at.AT_Type == AssaultTeam.AT_Types.Motorized_Guard){
					FactionManager.control.Factions [sfact].TotalMguards -= 1;
				}
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMotorInfantryWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Mechanized_Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMechInfantryWF) == true) {
				AssaultTeam MG = new MechInfantry (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMechInfantry += 1;
				FactionManager.control.Factions [sfact].TotalMinfantry -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMechInfantryWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Motorized_Recon") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMotorReconWarfunds) == true) {
				AssaultTeam MG = new MotorRecon (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMrecon += 1;
				FactionManager.control.Factions [sfact].TotalRecon -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMotorReconWarfunds;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}
		
		}else if (t == "Mechanized_Recon") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMechReconWarfunds) == true) {
				AssaultTeam MG = new MechRecon (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMechRecon += 1;
				FactionManager.control.Factions [sfact].TotalMrecon -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMechReconWarfunds;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Medium_Armor") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMediumArmorWF) == true) {
				AssaultTeam MG = new MediumArmor (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMediumArmor += 1;
				FactionManager.control.Factions [sfact].TotalLightArmor -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMediumArmorWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "MediumTankDestroyer") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToTankDestroyerWF) == true) {
				AssaultTeam MG = new Destroyers (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalDestroyers += 1;
				FactionManager.control.Factions [sfact].TotalLightArmor -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToTankDestroyerWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Heavy_Armor") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToHeavyArmorWF) == true) {
				AssaultTeam MG = new HeavyArmor (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalHeavyArmor += 1;
				FactionManager.control.Factions [sfact].TotalMediumArmor -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToHeavyArmorWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Paratroopers") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToParatrooperWF) == true) {
				AssaultTeam MG = new ParaTrooper (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalParatroopers += 1;
				FactionManager.control.Factions [sfact].TotalPathfinders -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToParatrooperWF;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Fighter_Squadron") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToMediumFightersWarfunds) == true) {
				AssaultTeam MG = new FighterSquadron (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalFighterSquadrons += 1;
				FactionManager.control.Factions [sfact].TotalReconFighters -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToMediumFightersWarfunds;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}
		
		}else if (t == "Heavy_Fighter") {
			if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, CostAndPrices.CAP.UgradeToHeavyFighterWarfunds) == true) {
				AssaultTeam MG = new HeavyFighterSquadron (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalHeavyFighterSquadrons += 1;
				FactionManager.control.Factions [sfact].TotalFighterSquadrons -= 1;
				GameControl.control.Warfunds -= CostAndPrices.CAP.UgradeToHeavyFighterWarfunds;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}
			

		ShowInfoAndAt (c, c.C_DeployID);
	}

	public void ModifyAT_GLD(AssaultTeam at, int id, string t, Character c, string sfact){
		// upgrading to
		if (t == "Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToInfantryGold) == true) {
				AssaultTeam IN = new ATInfantry (sfact);
				IN.AT_Name = at.AT_Name;
				IN.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalInfantry += 1;
				FactionManager.control.Factions [sfact].TotalGuards -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToInfantryGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add(IN);
				Debug.LogError ("Buyed " + IN.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Motorized_Guard") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMotorGuardGold) == true) {
				AssaultTeam MG = new MotorGuard (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMguards += 1;
				FactionManager.control.Factions [sfact].TotalGuards -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMotorGuardGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Motorized_Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMotorInfantryGold) == true) {
				AssaultTeam MG = new MotorizedInf (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMinfantry += 1;
				if(at.AT_Type == AssaultTeam.AT_Types.Infantry){
					FactionManager.control.Factions [sfact].TotalInfantry -= 1;
				}else if(at.AT_Type == AssaultTeam.AT_Types.Motorized_Guard){
					FactionManager.control.Factions [sfact].TotalMguards -= 1;
				}
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMotorInfantryGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Mechanized_Infantry") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMechInfantryGold) == true) {
				AssaultTeam MG = new MechInfantry (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMechInfantry += 1;
				FactionManager.control.Factions [sfact].TotalMinfantry -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMechInfantryGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Motorized_Recon") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMotorReconGold) == true) {
				AssaultTeam MG = new MotorRecon (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMechRecon += 1;
				FactionManager.control.Factions [sfact].TotalMrecon -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMotorReconGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}
		
		}else if (t == "Mechanized_Recon") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMechReconGold) == true) {
				AssaultTeam MG = new MechRecon (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMechRecon += 1;
				FactionManager.control.Factions [sfact].TotalMrecon -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMechReconGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}
		
		}else if (t == "Medium_Armor") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMediumArmorGold) == true) {
				AssaultTeam MG = new MediumArmor (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalMediumArmor += 1;
				FactionManager.control.Factions [sfact].TotalLightArmor -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMediumArmorGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}
		
		}else if (t == "MediumTankDestroyer") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToTankDestroyerGold) == true) {
				AssaultTeam MG = new Destroyers (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalDestroyers += 1;
				FactionManager.control.Factions [sfact].TotalLightArmor -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToTankDestroyerGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Heavy_Armor") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToHeavyArmorGold) == true) {
				AssaultTeam MG = new HeavyArmor (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalHeavyArmor += 1;
				FactionManager.control.Factions [sfact].TotalMediumArmor -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToHeavyArmorGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Paratroopers") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToParatrooperGold) == true) {
				AssaultTeam MG = new ParaTrooper (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalParatroopers += 1;
				FactionManager.control.Factions [sfact].TotalPathfinders -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToParatrooperGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Fighter_Squadron") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToMediumFighterGold) == true) {
				AssaultTeam MG = new FighterSquadron (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalFighterSquadrons += 1;
				FactionManager.control.Factions [sfact].TotalReconFighters -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToMediumFighterGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}else if (t == "Heavy_Fighter") {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.UgradeToHeavyFighterGold) == true) {
				AssaultTeam MG = new HeavyFighterSquadron (sfact);
				MG.AT_Name = at.AT_Name;
				MG.CharPanel = at.CharPanel;
				FactionManager.control.Factions [sfact].TotalHeavyFighterSquadrons += 1;
				FactionManager.control.Factions [sfact].TotalFighterSquadrons -= 1;
				GameControl.control.Gold -= CostAndPrices.CAP.UgradeToHeavyFighterGold;
				FactionManager.control.Factions[sfact].AssaultTeams.Add (MG);
				Debug.LogError ("Buyed " + MG.AT_Name);
				FactionManager.control.Factions[sfact].AssaultTeams.Remove (at);
			}else {
				return;
			}

		}


		ShowInfoAndAt (c, c.C_DeployID);
	}

	#endregion

	#region reset panels
	// reset all panels
	public void ResetPanel(Transform panel){
		var childrens = new List<GameObject> ();
		foreach (Transform child in panel.transform) {
			childrens.Add (child.gameObject);
			//Debug.Log (child.name);
		}
		if (childrens.Count > 0) {
			childrens.ForEach (child => Destroy (child));
		}
	}

	public void ResetAll(){
		ResetPanel (soldiers);
		ResetPanel (info);
		ResetPanel (AT);
		ResetPanel (buypanel);
		ResetPanel (modifypanel);
	}
	#endregion

	#region buy buttons
	public void buyWF(int price, string sfact, int id, string name, BuyAT bt, Character c){
		if (FactionManager.control.Factions [sfact].AssaultTeams == null) {
			
		}
//		if(c.AssaultTeamsOwned == null){c.AssaultTeamsOwned = new List<AssaultTeam> ();}
		if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, price) == false) {
			return;
		}

		if(name == "Guard"){
			
			AssaultTeam guard = new Guard (sfact);
			guard.CharPanel = atPrefab;

			if (bt._setName.text == "") {

			} else {
				guard.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					guard.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (guard);
//					Debug.LogError ("BuyWF set active ch.AssaultTeamsOwned.Add " + bt._setName.text);
//
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (guard);
			FactionManager.control.Factions [sfact].TotalGuards += 1;

			GameControl.control.Warfunds -= price;
			DestroyObj (bt.gameObject);
		}else if(name =="Para"){
			AssaultTeam fin = new ATPathfinder(sfact);
			fin.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				fin.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					fin.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (fin);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (fin);
			FactionManager.control.Factions [sfact].TotalPathfinders += 1;

			GameControl.control.Warfunds -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Recon"){
			AssaultTeam Rec = new ATRecon(sfact);
			Rec.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				Rec.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					Rec.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (Rec);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (Rec);
			FactionManager.control.Factions [sfact].TotalRecon += 1;

			GameControl.control.Warfunds -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Armor"){
			AssaultTeam Larm = new LightArmor(sfact);
			Larm.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				Larm.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					Larm.Owner_ID = ch.DeployID;
//					//ch.AssaultTeamsOwned.Add (Larm);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (Larm);
			FactionManager.control.Factions [sfact].TotalLightArmor += 1;

			GameControl.control.Warfunds -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Fighters"){
			AssaultTeam onF = new ReconFighter(sfact);
			onF.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				onF.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					onF.Owner_ID = ch.DeployID;
//					//ch.AssaultTeamsOwned.Add (onF);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (onF);
			FactionManager.control.Factions [sfact].TotalReconFighters += 1;

			GameControl.control.Warfunds -= price;
			DestroyObj (bt.gameObject);
		}
		ShowInfoAndAt (c, c.C_DeployID);
	}

	public void buyGLD(int price, string sfact, int id, string name, BuyAT bt, Character c){
		
		if (FactionManager.control.Factions [sfact].AssaultTeams == null) {
			//FactionManager.control.Factions [sfact].AssaultTeams = new List<AssaultTeam> ();
		}

		if (GameControl.control.CheckCurrency (GameControl.control.Gold, price) == false) {
			return;
		}

		if(name == "Guard"){
			AssaultTeam guard = new Guard (sfact);
			guard.CharPanel = atPrefab;

			if (bt._setName.text == "") {

			} else {
				guard.Rename (bt._setName.text);
			}
			Debug.LogError ("BuyWF set active " + bt._setName.text);
			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					guard.Owner_ID = ch.DeployID;
//					//ch.AssaultTeamsOwned.Add (guard);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (guard);
			FactionManager.control.Factions [sfact].TotalGuards += 1;

			GameControl.control.Gold -= price;
			DestroyObj (bt.gameObject);
		}else if(name =="Para"){
			AssaultTeam fin = new ATPathfinder(sfact);
			fin.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				fin.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					fin.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (fin);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (fin);
			FactionManager.control.Factions [sfact].TotalPathfinders += 1;

			GameControl.control.Gold -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Recon"){
			AssaultTeam Rec = new ATRecon(sfact);
			Rec.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				Rec.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					Rec.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (Rec);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (Rec);
			FactionManager.control.Factions [sfact].TotalRecon += 1;

			GameControl.control.Gold -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Armor"){
			AssaultTeam Larm = new LightArmor(sfact);
			Larm.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				Larm.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					Larm.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (Larm);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (Larm);
			FactionManager.control.Factions [sfact].TotalLightArmor += 1;

			GameControl.control.Gold -= price;
			DestroyObj (bt.gameObject);
		}else if(name == "Fighters"){
			AssaultTeam onF = new ReconFighter(sfact);
			onF.CharPanel = atPrefab;
			if (bt._setName.text == "") {

			} else {
				onF.Rename (bt._setName.text);
			}

			foreach(Character ch in FactionManager.control.Factions[sfact].Characters){
//				if (id == ch.DeployID) {
//					onF.Owner_ID = ch.DeployID;
//					ch.AssaultTeamsOwned.Add (onF);
//				}
			}

			FactionManager.control.Factions [sfact].AssaultTeams.Add (onF);
			FactionManager.control.Factions [sfact].TotalReconFighters += 1;

			GameControl.control.Gold -= price;
			DestroyObj (bt.gameObject);
		}
		ShowInfoAndAt (c, c.C_DeployID);
	}

	public void DestroyObj(GameObject go){
		Destroy (go);
		//ResetPanel (AT);
	}

	#endregion
}
