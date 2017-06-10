/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// Character.cs
/// 
/// </summary>
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System;

[Serializable]
/// <ToDo>
/// check code.
/// </ToDo>

public class Character {
	// Character display holder
	[NonSerialized]public CharacterHolder CharPanel;

	// ID
	[SerializeField]public int C_ID {get; set; }

	// Naming
	[SerializeField]public string C_Name{get; set; }

	// character image
	[SerializeField]public Texture C_Image {get; set;}

	// character class
	[SerializeField]public enum C_Type {InfantryMan, Para, Recon, TankMan, Pilot, General};

	[SerializeField]public C_Type Type{get; set; }

	// character Rank
	[SerializeField]public enum C_Rank {
		Private, // 0
		PrivateFirstClass, // 1
		Technician5thGrade, // 2
		Corporal, // 3
		SeniorCorporal, // 4
		Technician4thGrade, // 5
		Sergeant, // 6
		StaffSergeant, // 7
		TechnicalSergeant, // 8
		MasterSergeant, // 9
		FirstSergeant, // 10
		SergeantMajor, // 11
		SecondLieutenant, // 12
		FirstLieutenant, // 13
		Captain, // 14
		Major, // 15
		LieutenantColonel, // 16
		Colonel, // 17
		BrigadierGeneral, // 18
		MajorGeneral, // 19
		LieutenantGeneral, // 20
		General, //21
		GeneralOfTheArmy //22
	};

	[SerializeField]public C_Rank Rank{get; set; }

	[SerializeField]public Texture RankIcon { get; set; }

	// character faction
	[SerializeField]public enum C_Faction{US, SOVIET, GERMANY};

	[SerializeField]public C_Faction Faction{ get; set; }

	[SerializeField]public Texture FactionFlag{ get; set; }
	//
	// selection
	[SerializeField]public bool IsSelected {get; set;}

	// squad points
	[SerializeField]public static int SquadPoints { get; set; }
	[SerializeField]public static int MaxSquadPoints { get; set; }

	// DeploySystem
	[SerializeField]public int C_DeployID{get; set; }
	[SerializeField]public bool hasSavedDeploy {get; set;}
	// command points
	[SerializeField]public bool hasDeploy {get; set;}
	//[SerializeField]public List<int> AssaultTeamsDeployed = new List<int>();
	[SerializeField]public int CommandActivePoints { get; set; }

	// ranking
	[SerializeField]public int CommandPoints { get; set; }

	void Awake(){

	}

	// Use this for initialization
	void Start () {
		UIUpdate ();
	}

	// Update is called once per frame
	void Update () {
		UIUpdate ();

	}

	// setters
	// set the character name
	public void setName(string _name){
        if(!string.IsNullOrEmpty(_name))
		this.C_Name = _name;
		CharacterManager.characterManager.ShowChar (this.CharPanel, this, this.Faction.ToString ());
	}

	public void setGeneral(string _faction){
		
	}

	// switch carreer
	public void SwitchCareer(string _faction, string _newCareer, bool _gold){
		if (_gold == true) {
			if (GameControl.control.CheckCurrency (GameControl.control.Gold, CostAndPrices.CAP.CareerUpdateGold) == false) {
				return;
			}
			GameControl.control.Gold -= CostAndPrices.CAP.CareerUpdateGold;
		} else {
			if (GameControl.control.CheckCurrency (GameControl.control.Credits, CostAndPrices.CAP.CareerUpdateCred) == false) {
				return;
			}
			GameControl.control.Credits -= CostAndPrices.CAP.CareerUpdateCred;
		}

		C_Type current = Type;
		if (current == C_Type.InfantryMan) {
			FactionManager.control.Factions [_faction].TotalOwnedCharInf -= 1;
		}else if (current == C_Type.Para) {
			FactionManager.control.Factions [_faction].TotalOwnedCharPar -= 1;
		}else if (current == C_Type.Recon) {
			FactionManager.control.Factions [_faction].TotalOwnedCharRec -= 1;
		}else if (current == C_Type.TankMan) {
			FactionManager.control.Factions [_faction].TotalOwnedCharTan -= 1;
		}else if (current == C_Type.Pilot) {
			FactionManager.control.Factions [_faction].TotalOwnedCharPil -= 1;
		}

		if(_faction == "US"){
			Debug.Log ("switch career usa " + _newCareer);
			if (_newCareer == "Infantry") {
				Type = C_Type.InfantryMan;
				FactionManager.control.Factions [_faction].TotalOwnedCharInf += 1;
				setCareerImg (Type, _faction);
			} else if (_newCareer == "Para") {
				Type = C_Type.Para;
				FactionManager.control.Factions [_faction].TotalOwnedCharPar += 1;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Recon") {
				Type = C_Type.Recon;
				FactionManager.control.Factions [_faction].TotalOwnedCharRec += 1;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "TankMan") {
				Type = C_Type.TankMan;
				FactionManager.control.Factions [_faction].TotalOwnedCharTan += 1;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Pilot") {
				Type = C_Type.Pilot;
				FactionManager.control.Factions [_faction].TotalOwnedCharPil += 1;
				setCareerImg (Type, _faction);
			}
		}
		else if(_faction == "GERMANY"){
			Debug.Log ("switch career Germany "  + _newCareer);
			if (_newCareer == "Infantry") {
				Type = C_Type.InfantryMan;
				setCareerImg (Type, _faction);
			} else if (_newCareer == "Para") {
				Type = C_Type.Para;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Recon") {
				Type = C_Type.Recon;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "TankMan") {
				Type = C_Type.TankMan;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Pilot") {
				Type = C_Type.Pilot;
				setCareerImg (Type, _faction);
			}
		}
		else if(_faction == "SOVIET"){
			Debug.Log ("switch career Soviet "  + _newCareer);
			if (_newCareer == "Infantry") {
				Type = C_Type.InfantryMan;
				setCareerImg (Type, _faction);
			} else if (_newCareer == "Para") {
				Type = C_Type.Para;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Recon") {
				Type = C_Type.Recon;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "TankMan") {
				Type = C_Type.TankMan;
				setCareerImg (Type, _faction);
			}else if (_newCareer == "Pilot") {
				Type = C_Type.Pilot;
				setCareerImg (Type, _faction);
			}
		}

		//CharacterManager.characterManager.DisplayCharacter (_faction);
		//UIUpdate ();
		CharacterManager.characterManager.ShowChar (this.CharPanel, this, this.Faction.ToString ());
		//CharacterManager.characterManager.DisplayCharacter (_faction);
	}

	// update the Ranks
	public void updateRank (){
		//Get current Rank
		C_Rank current = Rank;
		// Rank switching from to
		switch(current){
		// todo: add texture for Rankicon, soldierImage
			// 0 to 1
		case C_Rank.Private:
			Rank = C_Rank.PrivateFirstClass;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
		
			break;
			// 1 to 2 
		case C_Rank.PrivateFirstClass:
			Rank = C_Rank.Technician5thGrade;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 2 to 3
		case C_Rank.Technician5thGrade:
			Rank = C_Rank.Corporal;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 3 to 4
		case C_Rank.Corporal:
			Rank = C_Rank.SeniorCorporal;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 4 to 5
		case C_Rank.SeniorCorporal:
			Rank = C_Rank.Technician4thGrade;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 5 to 6
		case C_Rank.Technician4thGrade:
			Rank = C_Rank.Sergeant;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 6 to 7
		case C_Rank.Sergeant:
			Rank = C_Rank.StaffSergeant;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 7 to 8
		case C_Rank.StaffSergeant:
			Rank = C_Rank.TechnicalSergeant;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 8 to 9
		case C_Rank.TechnicalSergeant:
			Rank = C_Rank.MasterSergeant;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 9 to 10
		case C_Rank.MasterSergeant:
			Rank = C_Rank.FirstSergeant;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 10 to 11
		case C_Rank.FirstSergeant:
			Rank = C_Rank.SergeantMajor;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 11 to 12
		case C_Rank.SergeantMajor:
			Rank = C_Rank.SecondLieutenant;
			setCommandPoints();
			RankIcon = FactionManager.control.Factions [Faction.ToString ()].Ranks [current];

			break;
			// 12 to 13
		case C_Rank.SecondLieutenant:
			Rank = C_Rank.FirstLieutenant;
			RankIcon = FactionManager.control.Factions [Faction.ToString ()].Ranks [current];

			break;
			// 13 to 14
		case C_Rank.FirstLieutenant:
			Rank = C_Rank.Captain;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			break;
			// 14 to 15
		case C_Rank.Captain:
			Rank = C_Rank.Major;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 15 to 16
		case C_Rank.Major:
			Rank = C_Rank.LieutenantColonel;
			RankIcon = FactionManager.control.Factions [Faction.ToString ()].Ranks [current];
			setCommandPoints();
			break;
			// 16 to 17
		case C_Rank.LieutenantColonel:
			Rank = C_Rank.Colonel;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 17 to 18
		case C_Rank.Colonel:
			Rank = C_Rank.BrigadierGeneral;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 18 to 19
		case C_Rank.BrigadierGeneral:
			Rank = C_Rank.MajorGeneral;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 19 to 20
		case C_Rank.MajorGeneral:
			Rank = C_Rank.LieutenantGeneral;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 20 to 21
		case C_Rank.LieutenantGeneral:
			Rank = C_Rank.General;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
			// 21 to 22
		case C_Rank.General:
			Rank = C_Rank.GeneralOfTheArmy;
			RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];
			setCommandPoints();
			break;
		}
		CharacterManager.characterManager.ShowChar (this.CharPanel, this, this.Faction.ToString ());
		//Debug.Log("UpdateRank() = " + getRank() + " CP: " + CommandPoints);

	}


	// Set the Rank icon on the character, make it a global function
	public void setRankIcon (string _faction){
		//Get current Rank

		C_Rank current = Rank;
		RankIcon = FactionManager.control.Factions [Faction.ToString()].Ranks [current];

		//UIUpdate ();

	}

	public Texture setCareerImg(C_Type career, string _faction){
		// Set the Career image for the character all factions
		if (_faction == "US") {
			switch (career) {
			case Character.C_Type.InfantryMan:
				C_Image = CharacterManager.characterManager.USInf;
				break;
			case Character.C_Type.Para:
				C_Image = CharacterManager.characterManager.USPara;
				break;
			case Character.C_Type.Recon:
				C_Image = CharacterManager.characterManager.USRecon;
				break;
			case Character.C_Type.TankMan:
				C_Image = CharacterManager.characterManager.USTank;
				break;
			case Character.C_Type.Pilot:
				C_Image = CharacterManager.characterManager.USPilot;
				break;
			case Character.C_Type.General:
				C_Image = CharacterManager.characterManager.USGeneral;
				break;
			}
		} else if (_faction == "GERMANY") {
			switch (career) {
			case Character.C_Type.InfantryMan:
				C_Image = CharacterManager.characterManager.GERMInf;
				break;
			case Character.C_Type.Para:
				C_Image = CharacterManager.characterManager.GERMPara;
				break;
			case Character.C_Type.Recon:
				C_Image = CharacterManager.characterManager.GERMRecon;
				break;
			case Character.C_Type.TankMan:
				C_Image = CharacterManager.characterManager.GERMTank;
				break;
			case Character.C_Type.Pilot:
				C_Image = CharacterManager.characterManager.GERMPilot;
				break;
			case Character.C_Type.General:
				C_Image = CharacterManager.characterManager.GERMGeneral;
				break;
			}
		} else if (_faction == "SOVIET") {
			switch (career) {
			case Character.C_Type.InfantryMan:
				C_Image = CharacterManager.characterManager.SOVInf;
				break;
			case Character.C_Type.Para:
				C_Image = CharacterManager.characterManager.SOVPara;
				break;
			case Character.C_Type.Recon:
				C_Image = CharacterManager.characterManager.SOVRecon;
				break;
			case Character.C_Type.TankMan:
				C_Image = CharacterManager.characterManager.SOVTank;
				break;
			case Character.C_Type.Pilot:
				C_Image = CharacterManager.characterManager.SOVPilot;
				break;
			case Character.C_Type.General:
				C_Image = CharacterManager.characterManager.SOVGeneral;
				break;
			}
		} 
		//UIUpdate ();
		CharacterManager.characterManager.DisplayCharacter (_faction);
		return C_Image;
	}

	// getters
	public string getName(){
		string n = C_Name;
		return n;
	}

	public C_Rank getRank(){
		return Rank;
	}

	public void UIUpdate () {
		this.CharPanel.CharacterImage.texture = this.C_Image;
		this.CharPanel.CharacterName.text = this.C_Name;
		this.CharPanel.CharacterFaction.texture = this.FactionFlag;
		this.CharPanel.CharacterRank.texture = this.RankIcon;
		this.CharPanel.CharacterRankName.text = this.Rank.ToString ();
	}

	// deploy system
	public int setActiveCommandPoints(int commandPointsactive){
		CommandActivePoints = commandPointsactive;
		return CommandActivePoints;
	}

	public void setCommandPoints(){
		//Get current Rank
		C_Rank current = this.Rank;
		// Rank switching from to
		switch(current){
		// todo: add texture for Rankicon, soldierImage
		// 0 to 1
		case C_Rank.Private:
//			

			break;
			// 1 to 2 
		case C_Rank.PrivateFirstClass:
//			
			break;
			// 2 to 3
		case C_Rank.Technician5thGrade:
//			
			break;
			// 3 to 4
		case C_Rank.Corporal:
//			
			break;
			// 4 to 5
		case C_Rank.SeniorCorporal:
//			
			break;
			// 5 to 6
		case C_Rank.Technician4thGrade:
//			
			break;
			// 6 to 7
		case C_Rank.Sergeant:
//			
			break;
			// 7 to 8
		case C_Rank.StaffSergeant:
//			
			break;
			// 8 to 9
		case C_Rank.TechnicalSergeant:
//			
			break;
			// 9 to 10
		case C_Rank.MasterSergeant:
//			
			break;
			// 10 to 11
		case C_Rank.FirstSergeant:
//			
			break;
			// 11 to 12
		case C_Rank.SergeantMajor:
			

			break;
			// 12 to 13
		case C_Rank.SecondLieutenant:
//			
			this.CommandPoints = 1;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}

			break;
			// 13 to 14
		case C_Rank.FirstLieutenant:
//			
			break;
			// 14 to 15
		case C_Rank.Captain:
//			
			break;
			// 15 to 16
		case C_Rank.Major:
//			
			this.CommandPoints = 2;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 16 to 17
		case C_Rank.LieutenantColonel:
//			
			this.CommandPoints = 3;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 17 to 18
		case C_Rank.Colonel:
//			
			this.CommandPoints = 4;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 18 to 19
		case C_Rank.BrigadierGeneral:
//			
			this.CommandPoints = 5;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 19 to 20
		case C_Rank.MajorGeneral:
//			
			this.CommandPoints = 6;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 20 to 21
		case C_Rank.LieutenantGeneral:
//			
			this.CommandPoints = 7;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
			// 21 to 22
		case C_Rank.General:
//			
			this.CommandPoints = 8;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
		case C_Rank.GeneralOfTheArmy:
			
			this.CommandPoints = 10;
			if(GameControl.control.IsSaved == false){
				this.CommandActivePoints = this.CommandPoints;
			}
			break;
		}

	}
}
