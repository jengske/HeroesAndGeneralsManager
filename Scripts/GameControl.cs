/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// GameControl.cs
/// 
/// </summary>
//using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

/// <ToDo>
/// clean old code.
/// </ToDo>

public class GameControl : MonoBehaviour {
	
	public static GameControl control; // reference
	private static FactionManager FM = FactionManager.control; // reference

	public readonly List<CharacterData> S_Characterdata = new List<CharacterData>();
	public readonly List<ATData> S_ATdata = new List<ATData>();

	public readonly Dictionary<string, int> USdeployed = new Dictionary<string, int> ();
	public readonly Dictionary<string, int> GERMdeployed = new Dictionary<string, int> ();
	public readonly Dictionary<string, int> SOVdeployed = new Dictionary<string, int> ();

	public ATHolder ats;

	public int s_atdata;
	public int s_cdata;
	public int C_ATDATA;
	public int CheckDB;
	public int CheckDB2;
	// Application  & Debugging
	public bool IsDebugging = false;
	public bool IsFirstTimeRun = true;
	public bool IsSaved = false;
	public int Totalsaved = 0;
	////////////////////////////////////////////////

	// credits, warfunds & gold states
	////////////////////////////////////////////////

	public int Credits = 0;

	public int Warfunds = 0;

	public int Gold = 0;

	////////////////////////////////////////////////
	// prefered factions
	////////////////////////////////////////////////

	//[SerializeField]public string[] Faction = new string[]{ "US", "Germany", "Soviet"};
	public string CurrentFaction;

	////////////////////////////////////////////////
	//User & Clan info
	////////////////////////////////////////////////
	public string clanName;
	public string inGameName;
	public int warCount = 0;
	//private readonly List<ClanData> clanData;

	////////////////////////////////////////////////
	//Ranks
	////////////////////////////////////////////////

	// icon list
	public List<RankData> RankIcons = new List<RankData>();

	////////////////////////////////////////////////
	///Lists and dictonaries
	/// ////////////////////////////////////////////////
	//Application storage

	// rankData
	//[SerializeField]public List<RankData> RankDataList = new List<RankData>();

	// faction
	public Dictionary<string, Faction> _FactionList;


	// Deploy storage holder
	//[SerializeField]public List<Deploys> Deployed = new List<Deploys>();

	////////////////////////////////////////////////
	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
		//_FactionList = FactionManager.control.Factions;
		//Structure ();
		if (Directory.Exists (Application.persistentDataPath + "/SavedData/")) {
			IsFirstTimeRun = false;
			SaveAndLoad.sal.FirstTimeLoad ();
		} else {
			IsFirstTimeRun = true;

		}

	}

	////////////////////////////////////////////////
	public int setWarCount()
	{
		return warCount ++;
	}

	// Save/Load Characters
	private void setCharData(string sfact){
		

		foreach (Character c in FactionManager.control.Factions[sfact].Characters) {
			CharacterData cd = new CharacterData ();
			cd.C_ID = c.C_ID;
			cd.C_DeployID = c.C_DeployID;
			cd.C_Name = c.C_Name;
			cd.Type = c.Type;
			cd.Rank = c.Rank;
			cd.Faction = c.Faction;
			cd.IsSelected = c.IsSelected;
			cd.CommandPoints = c.CommandPoints;
			cd.CommandActivePoints = c.CommandActivePoints;
			//cd.AssaultTeamsDeployed = c.AssaultTeamsDeployed;
			cd.hasDeployed = c.hasDeploy;
			cd.hasSavedDeploy = c.hasSavedDeploy;

			S_Characterdata.Add (cd);

		}
	}

	public void SetCharData (){
		S_Characterdata.Clear ();
		setCharData ("US");
		setCharData ("GERMANY");
		setCharData ("SOVIET");
	}

//	public void checkATdeployed(string sfact){
//	}

	public void GetCharData(){
		foreach(CharacterData cd in S_Characterdata){
			
				if (cd.Type == Character.C_Type.InfantryMan) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry(cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID = cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}
					

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;

				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharInf += 1;
				} else if (cd.Type == Character.C_Type.Para) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para (cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID =cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;


				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharPar += 1;
				} else if (cd.Type == Character.C_Type.Recon) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon (cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID =cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;


				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharRec += 1;
				} else if (cd.Type == Character.C_Type.TankMan) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman(cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID =cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;


				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharTan += 1;
				} else if (cd.Type == Character.C_Type.Pilot) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot (cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID =cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;


				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharPil += 1;
				} else if (cd.Type == Character.C_Type.General) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General (cd.Faction.ToString());
				inf.C_ID = cd.C_ID;
				inf.C_Name = cd.C_Name;
				inf.C_DeployID =cd.C_DeployID;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				if(cd.Faction == Character.C_Faction.US){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				}else if(cd.Faction == Character.C_Faction.GERMANY){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				}else if(cd.Faction == Character.C_Faction.SOVIET){
					inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				}

				inf.Rank = cd.Rank;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				inf.IsSelected = cd.IsSelected;
				inf.hasDeploy = cd.hasDeployed;
				inf.CommandPoints = cd.CommandPoints;
				inf.CommandActivePoints = cd.CommandActivePoints;
				//inf.AssaultTeamsDeployed = cd.AssaultTeamsDeployed;


				FactionManager.control.Factions [cd.Faction.ToString()].Characters.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalOwnedCharGen += 1;
				} else {
					return;
				}
			//Debug.LogError ("testercheck " + cd.AssaultTeamsDeployed.Count);
			}

	}

	// Save/Load Assault teams
	private void setATData(string sfact){
		Debug.Log ("setATData: Start");
		foreach(AssaultTeam at in FactionManager.control.Factions [sfact].AssaultTeams){
			ATData ad = new ATData ();
			ad.AT_ID = at.AT_ID;
			ad.Owner_ID = at.Owner_ID;
			ad.Faction = at.Faction;
			ad.AT_Type = at.AT_Type;
			ad.AT_Level = at.AT_Level;
			ad.AT_Name = at.AT_Name;
			ad.CommandPoints = at.CommandPoints;
			ad.Tag = at.Tag;
			ad.Vehicles = at.Vehicles;
			ad.Manpower = at.Manpower;
			ad.ViewerID = at.ViewerID;
			ad.deploy_ID = at.deployID;
			ad.IsActive = at.IsActive;
			ad.IsDeployed = at.IsDeployed;
			ad.readyForDeploy = at.readyForDeploy;
			ad.setForDeploy = at.setForDeploy;
			ad.IsSavedAndDeployed = true;

			Debug.Log ("setATData: add " + at.AT_Name);
			S_ATdata.Add (ad);
//			if(at.IsDeployed == true){
//				if(sfact == "US"){
//					USdeployed.Add (ad.AT_ID, ad.Owner_ID);
//				}else if(sfact == "GERMANY"){
//					GERMdeployed.Add (ad.AT_ID, ad.Owner_ID);
//				}else if(sfact == "SOVIET"){
//					SOVdeployed.Add (ad.AT_ID, ad.Owner_ID);
//				}
//			}

		}
		Debug.Log ("setATData: end");
	}

	public void SetATData(){
		Debug.Log ("SetATData");
		S_ATdata.Clear ();
		setATData ("US");
		setATData ("GERMANY");
		setATData ("SOVIET");
	}

	public void GetATData(){
		Debug.Log ("GetATData");
		foreach (ATData cd in S_ATdata) {
			if (cd.AT_Type == AssaultTeam.AT_Types.Guard) {
				AssaultTeam guard = new Guard (cd.Faction.ToString());
				guard.AT_ID = cd.AT_ID;
				guard.Owner_ID = cd.Owner_ID;
				guard.AT_Level = cd.AT_Level;
				guard.AT_Name = cd.AT_Name;
				guard.AT_Type = cd.AT_Type;
				guard.Faction = cd.Faction;
				guard.CommandPoints = cd.CommandPoints;
				guard.Vehicles = cd.Vehicles;
				guard.Manpower = cd.Manpower;
				guard.IsActive = cd.IsActive;
				guard.IsDeployed = cd.IsDeployed;
				guard.ViewerID = cd.ViewerID;
				guard.readyForDeploy = cd.readyForDeploy;
				guard.setForDeploy = cd.setForDeploy;



				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (guard);

				FactionManager.control.Factions [cd.Faction.ToString()].TotalGuards += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Motorized_Guard) {
				AssaultTeam Mguard = new MotorGuard(cd.Faction.ToString());
				Mguard.AT_ID = cd.AT_ID;
				Mguard.Owner_ID = cd.Owner_ID;
				Mguard.AT_Level = cd.AT_Level;
				Mguard.AT_Name = cd.AT_Name;
				Mguard.AT_Type = cd.AT_Type;
				Mguard.Faction = cd.Faction;
				Mguard.CommandPoints = cd.CommandPoints;
				Mguard.Vehicles = cd.Vehicles;
				Mguard.Manpower = cd.Manpower;
				Mguard.IsActive = cd.IsActive;
				Mguard.IsDeployed = cd.IsDeployed;
				Mguard.ViewerID = cd.ViewerID;
				Mguard.readyForDeploy = cd.readyForDeploy;
				Mguard.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Mguard);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMguards += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Infantry) {
				AssaultTeam inf = new ATInfantry(cd.Faction.ToString());
				inf.AT_ID = cd.AT_ID;
				inf.Owner_ID = cd.Owner_ID;
				inf.AT_Level = cd.AT_Level;
				inf.AT_Name = cd.AT_Name;
				inf.AT_Type = cd.AT_Type;
				inf.Faction = cd.Faction;
				inf.CommandPoints = cd.CommandPoints;
				inf.Vehicles = cd.Vehicles;
				inf.Manpower = cd.Manpower;
				inf.IsActive = cd.IsActive;
				inf.IsDeployed = cd.IsDeployed;
				inf.ViewerID = cd.ViewerID;
				inf.readyForDeploy = cd.readyForDeploy;
				inf.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (inf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalInfantry += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Motorized_Infantry) {
				AssaultTeam Minf = new MotorizedInf(cd.Faction.ToString());
				Minf.AT_ID = cd.AT_ID;
				Minf.Owner_ID = cd.Owner_ID;
				Minf.AT_Level = cd.AT_Level;
				Minf.AT_Name = cd.AT_Name;
				Minf.AT_Type = cd.AT_Type;
				Minf.Faction = cd.Faction;
				Minf.CommandPoints = cd.CommandPoints;
				Minf.Vehicles = cd.Vehicles;
				Minf.Manpower = cd.Manpower;
				Minf.IsActive = cd.IsActive;
				Minf.IsDeployed = cd.IsDeployed;
				Minf.ViewerID = cd.ViewerID;
				Minf.readyForDeploy = cd.readyForDeploy;
				Minf.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Minf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMinfantry += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Mechanized_Infantry) {
				AssaultTeam Mechinf = new MechInfantry(cd.Faction.ToString());
				Mechinf.AT_ID = cd.AT_ID;
				Mechinf.Owner_ID = cd.Owner_ID;
				Mechinf.AT_Level = cd.AT_Level;
				Mechinf.AT_Name = cd.AT_Name;
				Mechinf.AT_Type = cd.AT_Type;
				Mechinf.Faction = cd.Faction;
				Mechinf.CommandPoints = cd.CommandPoints;
				Mechinf.Vehicles = cd.Vehicles;
				Mechinf.Manpower = cd.Manpower;
				Mechinf.IsActive = cd.IsActive;
				Mechinf.IsDeployed = cd.IsDeployed;
				Mechinf.ViewerID = cd.ViewerID;
				Mechinf.readyForDeploy = cd.readyForDeploy;
				Mechinf.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Mechinf);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMechInfantry += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Recon) {
				AssaultTeam Rec = new ATRecon(cd.Faction.ToString());
				Rec.AT_ID = cd.AT_ID;
				Rec.Owner_ID = cd.Owner_ID;
				Rec.AT_Level = cd.AT_Level;
				Rec.AT_Name = cd.AT_Name;
				Rec.AT_Type = cd.AT_Type;
				Rec.Faction = cd.Faction;
				Rec.CommandPoints = cd.CommandPoints;
				Rec.Vehicles = cd.Vehicles;
				Rec.Manpower = cd.Manpower;
				Rec.IsActive = cd.IsActive;
				Rec.IsDeployed = cd.IsDeployed;
				Rec.ViewerID = cd.ViewerID;
				Rec.readyForDeploy = cd.readyForDeploy;
				Rec.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Rec);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalRecon += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Motorized_Recon) {
				AssaultTeam MRec = new MotorRecon(cd.Faction.ToString());
				MRec.AT_ID = cd.AT_ID;
				MRec.Owner_ID = cd.Owner_ID;
				MRec.AT_Level = cd.AT_Level;
				MRec.AT_Name = cd.AT_Name;
				MRec.AT_Type = cd.AT_Type;
				MRec.Faction = cd.Faction;
				MRec.CommandPoints = cd.CommandPoints;
				MRec.Vehicles = cd.Vehicles;
				MRec.Manpower = cd.Manpower;
				MRec.IsActive = cd.IsActive;
				MRec.IsDeployed = cd.IsDeployed;
				MRec.ViewerID = cd.ViewerID;
				MRec.readyForDeploy = cd.readyForDeploy;
				MRec.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (MRec);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMrecon += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Mechanized_Recon) {
				AssaultTeam MechRec = new MechRecon(cd.Faction.ToString());
				MechRec.AT_ID = cd.AT_ID;
				MechRec.Owner_ID = cd.Owner_ID;
				MechRec.AT_Level = cd.AT_Level;
				MechRec.AT_Name = cd.AT_Name;
				MechRec.AT_Type = cd.AT_Type;
				MechRec.Faction = cd.Faction;
				MechRec.CommandPoints = cd.CommandPoints;
				MechRec.Vehicles = cd.Vehicles;
				MechRec.Manpower = cd.Manpower;
				MechRec.IsActive = cd.IsActive;
				MechRec.IsDeployed = cd.IsDeployed;
				MechRec.ViewerID = cd.ViewerID;
				MechRec.readyForDeploy = cd.readyForDeploy;
				MechRec.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (MechRec);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMechRecon += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Pathfinders) {
				AssaultTeam fin = new ATPathfinder(cd.Faction.ToString());
				fin.AT_ID = cd.AT_ID;
				fin.Owner_ID = cd.Owner_ID;
				fin.AT_Level = cd.AT_Level;
				fin.AT_Name = cd.AT_Name;
				fin.AT_Type = cd.AT_Type;
				fin.Faction = cd.Faction;
				fin.CommandPoints = cd.CommandPoints;
				fin.Vehicles = cd.Vehicles;
				fin.Manpower = cd.Manpower;
				fin.IsActive = cd.IsActive;
				fin.IsDeployed = cd.IsDeployed;
				fin.ViewerID = cd.ViewerID;
				fin.readyForDeploy = cd.readyForDeploy;
				fin.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (fin);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalPathfinders += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Paratroopers) {
				AssaultTeam tro = new ParaTrooper(cd.Faction.ToString());
				tro.AT_ID = cd.AT_ID;
				tro.Owner_ID = cd.Owner_ID;
				tro.AT_Level = cd.AT_Level;
				tro.AT_Name = cd.AT_Name;
				tro.AT_Type = cd.AT_Type;
				tro.Faction = cd.Faction;
				tro.CommandPoints = cd.CommandPoints;
				tro.Vehicles = cd.Vehicles;
				tro.Manpower = cd.Manpower;
				tro.IsActive = cd.IsActive;
				tro.IsDeployed = cd.IsDeployed;
				tro.ViewerID = cd.ViewerID;
				tro.readyForDeploy = cd.readyForDeploy;
				tro.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (tro);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalParatroopers += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Light_Armor) {
				AssaultTeam Larm = new LightArmor(cd.Faction.ToString());
				Larm.AT_ID = cd.AT_ID;
				Larm.Owner_ID = cd.Owner_ID;
				Larm.AT_Level = cd.AT_Level;
				Larm.AT_Name = cd.AT_Name;
				Larm.AT_Type = cd.AT_Type;
				Larm.Faction = cd.Faction;
				Larm.CommandPoints = cd.CommandPoints;
				Larm.Vehicles = cd.Vehicles;
				Larm.Manpower = cd.Manpower;
				Larm.IsActive = cd.IsActive;
				Larm.IsDeployed = cd.IsDeployed;
				Larm.ViewerID = cd.ViewerID;
				Larm.readyForDeploy = cd.readyForDeploy;
				Larm.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Larm);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalLightArmor += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Medium_Armor) {
				AssaultTeam Marm = new MediumArmor(cd.Faction.ToString());
				Marm.AT_ID = cd.AT_ID;
				Marm.Owner_ID = cd.Owner_ID;
				Marm.AT_Level = cd.AT_Level;
				Marm.AT_Name = cd.AT_Name;
				Marm.AT_Type = cd.AT_Type;
				Marm.Faction = cd.Faction;
				Marm.CommandPoints = cd.CommandPoints;
				Marm.Vehicles = cd.Vehicles;
				Marm.Manpower = cd.Manpower;
				Marm.IsActive = cd.IsActive;
				Marm.IsDeployed = cd.IsDeployed;
				Marm.ViewerID = cd.ViewerID;
				Marm.readyForDeploy = cd.readyForDeploy;
				Marm.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Marm);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalMediumArmor += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.MediumTankDestroyer) {
				AssaultTeam td = new Destroyers(cd.Faction.ToString());
				td.AT_ID = cd.AT_ID;
				td.Owner_ID = cd.Owner_ID;
				td.AT_Level = cd.AT_Level;
				td.AT_Name = cd.AT_Name;
				td.AT_Type = cd.AT_Type;
				td.Faction = cd.Faction;
				td.CommandPoints = cd.CommandPoints;
				td.Vehicles = cd.Vehicles;
				td.Manpower = cd.Manpower;
				td.IsActive = cd.IsActive;
				td.IsDeployed = cd.IsDeployed;
				td.ViewerID = cd.ViewerID;
				td.readyForDeploy = cd.readyForDeploy;
				td.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (td);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalDestroyers += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Heavy_Armor) {
				AssaultTeam Harm = new HeavyArmor(cd.Faction.ToString());
				Harm.AT_ID = cd.AT_ID;
				Harm.Owner_ID = cd.Owner_ID;
				Harm.AT_Level = cd.AT_Level;
				Harm.AT_Name = cd.AT_Name;
				Harm.AT_Type = cd.AT_Type;
				Harm.Faction = cd.Faction;
				Harm.CommandPoints = cd.CommandPoints;
				Harm.Vehicles = cd.Vehicles;
				Harm.Manpower = cd.Manpower;
				Harm.IsActive = cd.IsActive;
				Harm.IsDeployed = cd.IsDeployed;
				Harm.ViewerID = cd.ViewerID;
				Harm.readyForDeploy = cd.readyForDeploy;
				Harm.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Harm);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalHeavyArmor += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Fighter_Recon) {
				AssaultTeam onF = new ReconFighter(cd.Faction.ToString());
				onF.AT_ID = cd.AT_ID;
				onF.Owner_ID = cd.Owner_ID;
				onF.AT_Level = cd.AT_Level;
				onF.AT_Name = cd.AT_Name;
				onF.AT_Type = cd.AT_Type;
				onF.Faction = cd.Faction;
				onF.CommandPoints = cd.CommandPoints;
				onF.Vehicles = cd.Vehicles;
				onF.Manpower = cd.Manpower;
				onF.IsActive = cd.IsActive;
				onF.IsDeployed = cd.IsDeployed;
				onF.ViewerID = cd.ViewerID;
				onF.readyForDeploy = cd.readyForDeploy;
				onF.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (onF);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalReconFighters += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Fighter_Squadron) {
				AssaultTeam Squ = new FighterSquadron(cd.Faction.ToString());
				Squ.AT_ID = cd.AT_ID;
				Squ.Owner_ID = cd.Owner_ID;
				Squ.AT_Level = cd.AT_Level;
				Squ.AT_Name = cd.AT_Name;
				Squ.AT_Type = cd.AT_Type;
				Squ.Faction = cd.Faction;
				Squ.CommandPoints = cd.CommandPoints;
				Squ.Vehicles = cd.Vehicles;
				Squ.Manpower = cd.Manpower;
				Squ.IsActive = cd.IsActive;
				Squ.IsDeployed = cd.IsDeployed;
				Squ.ViewerID = cd.ViewerID;
				Squ.readyForDeploy = cd.readyForDeploy;
				Squ.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (Squ);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalFighterSquadrons += 1;
			} else if (cd.AT_Type == AssaultTeam.AT_Types.Heavy_Fighter) {
				AssaultTeam ron = new HeavyFighterSquadron(cd.Faction.ToString());
				ron.AT_ID = cd.AT_ID;
				ron.Owner_ID = cd.Owner_ID;
				ron.AT_Level = cd.AT_Level;
				ron.AT_Name = cd.AT_Name;
				ron.AT_Type = cd.AT_Type;
				ron.Faction = cd.Faction;
				ron.CommandPoints = cd.CommandPoints;
				ron.Vehicles = cd.Vehicles;
				ron.Manpower = cd.Manpower;
				ron.IsActive = cd.IsActive;
				ron.IsDeployed = cd.IsDeployed;
				ron.ViewerID = cd.ViewerID;
				ron.readyForDeploy = cd.readyForDeploy;
				ron.setForDeploy = cd.setForDeploy;

				FactionManager.control.Factions [cd.Faction.ToString()].AssaultTeams.Add (ron);
				FactionManager.control.Factions [cd.Faction.ToString()].TotalHeavyFighterSquadrons += 1;
			} 

		}

	}
	// needs checking

//	public void GetDeploylist(string sfact){
//		Debug.LogError ("getdeployList " + sfact);
//		if (sfact == "US"){
//			foreach (KeyValuePair<string,int> j in USdeployed) {
//				Debug.LogError (j.Key + " - " + j.Value);
//				foreach (Character c in FactionManager.control.Factions[sfact].Characters) {
//					foreach(AssaultTeam t in FactionManager.control.Factions[sfact].AssaultTeams){
//
//						if( j.Value == c.C_DeployID){
//							//DeploySystem.DS.DeployAT(sfact, c.C_DeployID, c, t, t.CharPanel);
////							Debug.LogError ("DeployAT()");
//							int tmpCount = WarManager.WM.DeployCounter++;
//							//		Deploydata dd = new Deploydata (c.C_DeployID, c, at, true);
//							//		// adapt all code and adjust the files
//							//		//at.Owner_ID = c.C_DeployID;
//							//		//c.AssaultTeamsDeployed.Add(at);
//							//		FactionManager.control.Factions [sfact].AssaultTeamsdeployed.Add (tmpCount, dd);
//							//////////////
//							t.IsDeployed = true;
//							t.Owner_ID = c.C_DeployID;
//							c.CommandActivePoints -= t.CommandPoints;
//							t.IsActive = true;
//							///ATHolder ats = new ATHolder ();
//							Deploydata dd = new Deploydata (c.C_DeployID, c, t, false);
//							dd.activeCommandPoints = c.CommandActivePoints;
//							FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Add (WarManager.WM.DeployCounter++, dd);
//							if (t.CharPanel == null) {
//								Debug.LogError ("no atholder found");
//								t.CharPanel = ats;
//							}
//							t.CharPanel.active = true;
//							if(t.IsDeployed == true){
//								if(c.Faction.ToString() == "US"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.USdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "GERMANY"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.GERMdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "SOVIET"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.SOVdeployed.Add (t.AT_Name, c.C_DeployID);
//								}
//							}
//							t.CharPanel.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => ATmanager.atManager.ShowAT(c.Faction.ToString()));
//						}
//					}
//
//				}
//			}
//
//		}else if (sfact == "GERMANY"){
//			foreach (KeyValuePair<string,int> jj in GERMdeployed) {
//				Debug.LogError (jj.Key + " - " + jj.Value);
//				foreach (Character c in FactionManager.control.Factions[sfact].Characters) {
//					foreach(AssaultTeam t in FactionManager.control.Factions[sfact].AssaultTeams){
//
//						if( jj.Value == c.C_DeployID){
//							Debug.LogError ("DeployAT()");
//							int tmpCount = WarManager.WM.DeployCounter++;
//							//		Deploydata dd = new Deploydata (c.C_DeployID, c, at, true);
//							//		// adapt all code and adjust the files
//							//		//at.Owner_ID = c.C_DeployID;
//							//		//c.AssaultTeamsDeployed.Add(at);
//							//		FactionManager.control.Factions [sfact].AssaultTeamsdeployed.Add (tmpCount, dd);
//							//////////////
//							t.IsDeployed = true;
//							t.Owner_ID = c.C_DeployID;
//							c.CommandActivePoints -= t.CommandPoints;
//							t.IsActive = true;
//							///ATHolder ats = new ATHolder ();
//							Deploydata dd = new Deploydata (c.C_DeployID, c, t, false);
//							dd.activeCommandPoints = c.CommandActivePoints;
//							FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Add (WarManager.WM.DeployCounter++, dd);
//							if (t.CharPanel == null) {
//								Debug.LogError ("no atholder found");
//								t.CharPanel = ats;
//							}
//							t.CharPanel.active = true;
//							if(t.IsDeployed == true){
//								if(c.Faction.ToString() == "US"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.USdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "GERMANY"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.GERMdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "SOVIET"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.SOVdeployed.Add (t.AT_Name, c.C_DeployID);
//								}
//							}
//							t.CharPanel.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => ATmanager.atManager.ShowAT(c.Faction.ToString()));
//						}
//					}
//
//				}
//			}
//
//
//		}else if (sfact == "SOVIET"){
//			foreach (KeyValuePair<string,int> js in SOVdeployed) {
//				Debug.LogError (js.Key + " - " + js.Value);
//				foreach (Character c in FactionManager.control.Factions[sfact].Characters) {
//					foreach(AssaultTeam t in FactionManager.control.Factions[sfact].AssaultTeams){
//
//						if( js.Value == c.C_DeployID){
//							Debug.LogError ("DeployAT()");
//							int tmpCount = WarManager.WM.DeployCounter++;
//							//		Deploydata dd = new Deploydata (c.C_DeployID, c, at, true);
//							//		// adapt all code and adjust the files
//							//		//at.Owner_ID = c.C_DeployID;
//							//		//c.AssaultTeamsDeployed.Add(at);
//							//		FactionManager.control.Factions [sfact].AssaultTeamsdeployed.Add (tmpCount, dd);
//							//////////////
//							t.IsDeployed = true;
//							t.Owner_ID = c.C_DeployID;
//							c.CommandActivePoints -= t.CommandPoints;
//							t.IsActive = true;
//							///ATHolder ats = new ATHolder ();
//							Deploydata dd = new Deploydata (c.C_DeployID, c, t, false);
//							dd.activeCommandPoints = c.CommandActivePoints;
//							FactionManager.control.Factions [c.Faction.ToString ()].AssaultTeamsdeployed.Add (WarManager.WM.DeployCounter++, dd);
//							if (t.CharPanel == null) {
//								Debug.LogError ("no atholder found");
//								t.CharPanel = ats;
//							}
//							t.CharPanel.active = true;
//							if(t.IsDeployed == true){
//								if(c.Faction.ToString() == "US"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.USdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "GERMANY"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.GERMdeployed.Add (t.AT_Name, c.C_DeployID);
//								}else if(c.Faction.ToString() == "SOVIET"){
//									c.AssaultTeamsDeployed.Add (t.AT_ID);
//									//GameControl.control.SOVdeployed.Add (t.AT_Name, c.C_DeployID);
//								}
//							}
//							t.CharPanel.GetComponent<ATHolder> ().isDeployed.onValueChanged.AddListener ((bool tz) => ATmanager.atManager.ShowAT(c.Faction.ToString()));
//						}
//					}
//
//				}
//			}
//		}
//
//		////
//
//	}

	void Start(){
		
		if (IsDebugging) {
			//Debug.Log ("Debug On");
		}

		if (IsFirstTimeRun) {
			if (IsDebugging) {
				Debug.Log ("First Time run On");
			}
				
		}

		if (!IsFirstTimeRun) {
			if (IsDebugging) {
				Debug.Log ("First Time run completed");
			}

		}
		_FactionList = FactionManager.control.Factions;

	}

	public bool CheckCurrency( int a, int b)
	{
		bool on;
		if (a < b) {
			on = false;
		} else {
			on = true;
		}
		Debug.LogError ("check currency; " + on);
		return on;
	}

	void FirstTimeRun(){

		// Get user information
		//Debug.Log(FC.StringToInt("6520") + " " + FC.StringToFloat ("55"));


		
	}

	void Update(){
		s_atdata = S_ATdata.Count;
		s_cdata = S_Characterdata.Count;
		C_ATDATA = FactionManager.control.Factions ["US"].AssaultTeams.Count;
		CheckDB = FactionManager.control.Factions ["US"].AssaultTeamsdeployed.Count;
		CheckDB2 = USdeployed.Count;
	}
}

