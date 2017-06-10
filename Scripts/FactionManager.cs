using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class FactionManager : MonoBehaviour {
	public static FactionManager control;
	public Faction USFaction;
	public Faction GERMANFaction;
	public Faction SOVIETFaction;

	private Character ch;
	public Dictionary<string, Faction> Factions = new Dictionary<string, Faction>();
	public List<Faction> FactionList;
	public FactionHolder factionPrefab;
	public RectTransform factionSpawn;


	void Awake(){
		if (control == null) {
			DontDestroyOnLoad (this.gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}

		FactionList = new List<Faction> ();
		SetFactions ();
		//getRankIcon("Private");
	}

	// Use this for initialization
	void Start () {
		



		foreach(KeyValuePair<string,Faction> F in Factions){
			//Debug.Log (F.ToString ());
			FactionHolder t = Instantiate (factionPrefab);
			t.name = F.Key;
			t.transform.SetParent (factionSpawn.transform);
			t.transform.localPosition = new Vector2 (0.0f, 0.0f);
			F.Value.FactionPrefab = t;
			t.isActive = false;
			t.Flag.texture = F.Value.Flag;
			t.gameObject.SetActive (false);
			F.Value.FactionPrefab.GetComponent<FactionHolder> ().cCharacters.text = FactionManager.control.Factions [F.Value.Name].TotalOwnedChar.ToString();

		}
		if (GameControl.control.CurrentFaction == "US"){
			ShowUS ();
		}else if (GameControl.control.CurrentFaction == "GERMANY"){
			ShowGERM ();
		}else if (GameControl.control.CurrentFaction == "SOVIET"){
			ShowSOV ();
		}
	}

	// Update is called once per frame
	void Update () {
		UpdateUI ();
	}



	void SetFactions(){
		
		// create the factions
		USFaction = new US ();
		USFaction.FactionPrefab = factionPrefab;
		Factions.Add ("US",USFaction);
		USFaction.Tag = "US";
		FactionList.Add (USFaction);
		setUSRankImages ();
		//Debug.Log ("US faction set. " + USFaction.Tag);

		GERMANFaction = new GERMANY ();
		GERMANFaction.FactionPrefab = factionPrefab;
		GERMANFaction.Tag = "GE";
		Factions.Add ("GERMANY", GERMANFaction);
		FactionList.Add (GERMANFaction);
		setGERMANRankImages ();
		//Debug.Log ("GERMAN faction set. " + GERMANFaction.Tag);

		SOVIETFaction = new SOVIET ();
		SOVIETFaction.FactionPrefab = factionPrefab;
		SOVIETFaction.Tag = "USSR";
		Factions.Add ("SOVIET", SOVIETFaction);
		FactionList.Add (SOVIETFaction);
		setSOVIETRankImages ();
		//Debug.Log ("SOVIET faction set. " + SOVIETFaction.Tag);
	}

	public void ShowUS(){
		if (GERMANFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true || SOVIETFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true) {
			return;
		}

		USFaction.FactionPrefab.gameObject.SetActive (true);
		USFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive = true;
		updateholder("US");
		USFaction.FactionPrefab.GetComponent<FactionHolder> ().cCharacters.text = FactionManager.control.Factions ["US"].TotalOwnedChar.ToString();

	

	}

	public void ShowGERM(){
		if (USFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true || SOVIETFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true) {
			return;
		}

		GERMANFaction.FactionPrefab.gameObject.SetActive (true);
		GERMANFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive = true;
		updateholder("GERMANY");
		GERMANFaction.FactionPrefab.GetComponent<FactionHolder> ().cCharacters.text = FactionManager.control.Factions ["GERMANY"].TotalOwnedChar.ToString();
	}

	public void ShowSOV(){
		if (GERMANFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true || USFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive == true) {
			return;
		}

		SOVIETFaction.FactionPrefab.gameObject.SetActive (true);
		SOVIETFaction.FactionPrefab.GetComponent<FactionHolder> ().isActive = true;
		updateholder("SOVIET");
		SOVIETFaction.FactionPrefab.GetComponent<FactionHolder> ().cCharacters.text = FactionManager.control.Factions ["SOVIET"].TotalOwnedChar.ToString();
	}

	void UpdateUI()
	{
		//NewFaction.FactionPrefab.GetComponent<FactionHolder> ().Flag.texture = NewFaction.Flag;
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////
	// naming system
	////////////////////////////////////////////////////////////////////////////////////////////////////////////

	// add character names
	public void AddUSName(Text _Name){
		if (USFaction.CharactersNames.Contains (_Name.text)) {
			Debug.Log ("Name already in database.");

			return;
		} else {
			USFaction.CharactersNames.Add (_Name.text);

			Debug.Log (_Name.text.ToString() + " added to the US Naming list");

		}

	}

	public void AddGERMANName(Text _Name){
		if(GERMANFaction.CharactersNames.Contains (_Name.text)){
			Debug.Log ("Name already in database.");
			return;
		}else{
			GERMANFaction.CharactersNames.Add (_Name.text);
			Debug.Log (_Name.text.ToString() + " added to the GERMAN Naming list");
		}

	}

	public void AddSOVIETName(Text _Name){
		if(SOVIETFaction.CharactersNames.Contains (_Name.text)){
			Debug.Log ("Name already in database.");
			return;
		}else{
			SOVIETFaction.CharactersNames.Add (_Name.text);
			Debug.Log (_Name.text.ToString() + " added to the SOVIET Naming list");
		}

	}

	// add assault team names
	public void AddUSATName(Text _Name){
		if(USFaction.ATNames.Contains (_Name.text)){
			Debug.Log ("Name already in database.");
			return;
		}else{
			USFaction.ATNames.Add (_Name.text);
			Debug.Log (_Name.text.ToString() + " added to the US assault team Naming list");
		}

	}

	public void AddGERMANATName(Text _Name){
		if(GERMANFaction.ATNames.Contains (_Name.text)){
			Debug.Log ("Name already in database.");
			return;
		}else{
			GERMANFaction.ATNames.Add (_Name.text);
			Debug.Log (_Name.text.ToString() + " added to the GERMAN assault team Naming list");
		}


	}

	public void AddSOVIETATName(Text _Name){
		if(SOVIETFaction.ATNames.Contains (_Name.text)){
			Debug.Log ("Name already in database.");
			return;
		}else{
			SOVIETFaction.ATNames.Add (_Name.text);
			Debug.Log (_Name.text.ToString() + " added to the SOVIET assault team Naming list");
		
		}

	}

	public void ShowUSNames(){
		foreach (string name in USFaction.CharactersNames)
		{
			Debug.Log (name);
		}
	}

	public void ShowGERMNames(){
		foreach (string name in GERMANFaction.CharactersNames)
		{
			Debug.Log (name);
		}
	}

	public void ShowSOVIETNames(){
		foreach (string name in SOVIETFaction.CharactersNames)
		{
			Debug.Log (name);
		}
	}

	#region set stats
	public void updateholder(string faction){
		FactionManager.control.Factions [faction].TotalOwnedChar = FactionManager.control.Factions [faction].Characters.Count;
		FactionManager.control.Factions [faction].FactionPrefab.cCharacters.text = FactionManager.control.Factions [faction].TotalOwnedChar.ToString();
		// Characters owned
		FactionManager.control.Factions [faction].FactionPrefab.cInfantry.text = FactionManager.control.Factions [faction].TotalOwnedCharInf.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.cPara.text = FactionManager.control.Factions [faction].TotalOwnedCharPar.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.cRecon.text = FactionManager.control.Factions [faction].TotalOwnedCharRec.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.cTankman.text = FactionManager.control.Factions [faction].TotalOwnedCharTan.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.cPilot.text = FactionManager.control.Factions [faction].TotalOwnedCharPil.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.cGeneral.text = FactionManager.control.Factions [faction].TotalOwnedCharGen.ToString();

		// Assaultteams owned
		FactionManager.control.Factions [faction].FactionPrefab.atGuard.text = FactionManager.control.Factions [faction].TotalGuards.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atInfantry.text = FactionManager.control.Factions [faction].TotalInfantry.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMotorizedGuard.text = FactionManager.control.Factions [faction].TotalMguards.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMotorizedInfantry.text = FactionManager.control.Factions [faction].TotalMinfantry.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMechanizedInfantry.text = FactionManager.control.Factions [faction].TotalMechInfantry.ToString();

		FactionManager.control.Factions [faction].FactionPrefab.atRecon.text = FactionManager.control.Factions [faction].TotalRecon.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMotorizedRecon.text = FactionManager.control.Factions [faction].TotalMrecon.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMechanizedRecon.text = FactionManager.control.Factions [faction].TotalMechRecon.ToString();

		FactionManager.control.Factions [faction].FactionPrefab.atLightArmor.text = FactionManager.control.Factions [faction].TotalLightArmor.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atMediumArmor.text = FactionManager.control.Factions [faction].TotalMediumArmor.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atDestroyers.text = FactionManager.control.Factions [faction].TotalDestroyers.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atHeavyArmor.text = FactionManager.control.Factions [faction].TotalHeavyArmor.ToString();

		FactionManager.control.Factions [faction].FactionPrefab.atPathfinders.text = FactionManager.control.Factions [faction].TotalPathfinders.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atParatroopers.text = FactionManager.control.Factions [faction].TotalParatroopers.ToString();

		FactionManager.control.Factions [faction].FactionPrefab.atReconFighters.text = FactionManager.control.Factions [faction].TotalReconFighters.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atFighters.text = FactionManager.control.Factions [faction].TotalFighterSquadrons.ToString();
		FactionManager.control.Factions [faction].FactionPrefab.atHeavyFighters.text = FactionManager.control.Factions [faction].TotalHeavyFighterSquadrons.ToString();

	}
	#endregion
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	//RankSystem
	// US
	public void setUSRankImages(){
		Texture[] ranks = Resources.LoadAll<Texture> ("Factions/Ranks/US");
		foreach (Texture tex in ranks) {
			if (tex.name == "1_1_0") {
				USFaction.Ranks.Add (Character.C_Rank.Private, tex);
			}else if (tex.name == "1_1_1") {
				USFaction.Ranks.Add (Character.C_Rank.PrivateFirstClass, tex);
			}else if (tex.name == "1_1_2") {
				USFaction.Ranks.Add (Character.C_Rank.Technician5thGrade, tex);
			}else if (tex.name == "1_1_3") {
				USFaction.Ranks.Add (Character.C_Rank.Corporal, tex);
			}else if (tex.name == "1_1_4") {
				USFaction.Ranks.Add (Character.C_Rank.SeniorCorporal, tex);
			}else if (tex.name == "1_1_5") {
				USFaction.Ranks.Add (Character.C_Rank.Technician4thGrade, tex);
			}else if (tex.name == "1_1_6") {
				USFaction.Ranks.Add (Character.C_Rank.Sergeant, tex);
			}else if (tex.name == "1_1_7") {
				USFaction.Ranks.Add (Character.C_Rank.StaffSergeant, tex);
			}else if (tex.name == "1_1_8") {
				USFaction.Ranks.Add (Character.C_Rank.TechnicalSergeant, tex);
			}else if (tex.name == "1_1_9") {
				USFaction.Ranks.Add (Character.C_Rank.MasterSergeant, tex);
			}else if (tex.name == "1_1_10") {
				USFaction.Ranks.Add (Character.C_Rank.FirstSergeant, tex);
			}else if (tex.name == "1_1_11") {
				USFaction.Ranks.Add (Character.C_Rank.SergeantMajor, tex);
			}else if (tex.name == "1_1_12") {
				USFaction.Ranks.Add (Character.C_Rank.SecondLieutenant, tex);
			}else if (tex.name == "1_1_13") {
				USFaction.Ranks.Add (Character.C_Rank.FirstLieutenant, tex);
			}else if (tex.name == "1_1_14") {
				USFaction.Ranks.Add (Character.C_Rank.Captain, tex);
			}else if (tex.name == "1_1_15") {
				USFaction.Ranks.Add (Character.C_Rank.Major, tex);
			}else if (tex.name == "1_1_16") {
				USFaction.Ranks.Add (Character.C_Rank.LieutenantColonel, tex);
			}else if (tex.name == "1_1_17") {
				USFaction.Ranks.Add (Character.C_Rank.Colonel, tex);
			}else if (tex.name == "1_1_18") {
				USFaction.Ranks.Add (Character.C_Rank.BrigadierGeneral, tex);
			}else if (tex.name == "1_1_19") {
				USFaction.Ranks.Add (Character.C_Rank.MajorGeneral, tex);
			}else if (tex.name == "1_1_20") {
				USFaction.Ranks.Add (Character.C_Rank.LieutenantGeneral, tex);
			}else if (tex.name == "1_1_21") {
				USFaction.Ranks.Add (Character.C_Rank.General, tex);
			}else if (tex.name == "1_1_22") {
				USFaction.Ranks.Add (Character.C_Rank.GeneralOfTheArmy, tex);
			}
		}

	}

	public Texture getRankIcon(string rank)
	{
		Texture t = null;
		foreach (KeyValuePair<Character.C_Rank,Texture> tx in USFaction.Ranks) {
			if(rank == tx.Key.ToString()){
				t = tx.Value;
				//Debug.Log (tx.Value);
			}
		}

		return t;
	}
	// GERMAN
	public void setGERMANRankImages(){
		Texture[] ranks = Resources.LoadAll<Texture> ("Factions/Ranks/GERMANY");
		foreach (Texture tex in ranks) {
			if (tex.name == "2_1_0") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Private, tex);
			}else if (tex.name == "2_1_1") {
				GERMANFaction.Ranks.Add (Character.C_Rank.PrivateFirstClass, tex);
			}else if (tex.name == "2_1_2") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Technician5thGrade, tex);
			}else if (tex.name == "2_1_3") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Corporal, tex);
			}else if (tex.name == "2_1_4") {
				GERMANFaction.Ranks.Add (Character.C_Rank.SeniorCorporal, tex);
			}else if (tex.name == "2_1_5") {
						GERMANFaction.Ranks.Add (Character.C_Rank.Technician4thGrade, tex);
			}else if (tex.name == "2_1_6") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Sergeant, tex);
			}else if (tex.name == "2_1_7") {
				GERMANFaction.Ranks.Add (Character.C_Rank.StaffSergeant, tex);
			}else if (tex.name == "2_1_8") {
				GERMANFaction.Ranks.Add (Character.C_Rank.TechnicalSergeant, tex);
			}else if (tex.name == "2_1_9") {
				GERMANFaction.Ranks.Add (Character.C_Rank.MasterSergeant, tex);
			}else if (tex.name == "2_1_10") {
				GERMANFaction.Ranks.Add (Character.C_Rank.FirstSergeant, tex);
			}else if (tex.name == "2_1_11") {
				GERMANFaction.Ranks.Add (Character.C_Rank.SergeantMajor, tex);
			}else if (tex.name == "2_1_12") {
				GERMANFaction.Ranks.Add (Character.C_Rank.SecondLieutenant, tex);
			}else if (tex.name == "2_1_13") {
				GERMANFaction.Ranks.Add (Character.C_Rank.FirstLieutenant, tex);
			}else if (tex.name == "2_1_14") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Captain, tex);
			}else if (tex.name == "2_1_15") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Major, tex);
			}else if (tex.name == "2_1_16") {
				GERMANFaction.Ranks.Add (Character.C_Rank.LieutenantColonel, tex);
			}else if (tex.name == "2_1_17") {
				GERMANFaction.Ranks.Add (Character.C_Rank.Colonel, tex);
			}else if (tex.name == "2_1_18") {
				GERMANFaction.Ranks.Add (Character.C_Rank.BrigadierGeneral, tex);
			}else if (tex.name == "2_1_19") {
				GERMANFaction.Ranks.Add (Character.C_Rank.MajorGeneral, tex);
			}else if (tex.name == "2_1_20") {
				GERMANFaction.Ranks.Add (Character.C_Rank.LieutenantGeneral, tex);
			}else if (tex.name == "2_1_21") {
				GERMANFaction.Ranks.Add (Character.C_Rank.General, tex);
			}else if (tex.name == "2_1_22") {
				GERMANFaction.Ranks.Add (Character.C_Rank.GeneralOfTheArmy, tex);
			}
		}
	}

	// SOVIET
	public void setSOVIETRankImages(){
		Texture[] ranks = Resources.LoadAll<Texture> ("Factions/Ranks/SOVIET");
		foreach (Texture tex in ranks) {
			if (tex.name == "3_1_0") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Private, tex);
			}else if (tex.name == "3_1_1") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.PrivateFirstClass, tex);
			}else if (tex.name == "3_1_2") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Technician5thGrade, tex);
			}else if (tex.name == "3_1_3") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Corporal, tex);
			}else if (tex.name == "3_1_4") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.SeniorCorporal, tex);
			}else if (tex.name == "3_1_5") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Technician4thGrade, tex);
			}else if (tex.name == "3_1_6") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Sergeant, tex);
			}else if (tex.name == "3_1_7") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.StaffSergeant, tex);
			}else if (tex.name == "3_1_8") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.TechnicalSergeant, tex);
			}else if (tex.name == "3_1_9") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.MasterSergeant, tex);
			}else if (tex.name == "3_1_10") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.FirstSergeant, tex);
			}else if (tex.name == "3_1_11") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.SergeantMajor, tex);
			}else if (tex.name == "3_1_12") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.SecondLieutenant, tex);
			}else if (tex.name == "3_1_13") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.FirstLieutenant, tex);
			}else if (tex.name == "3_1_14") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Captain, tex);
			}else if (tex.name == "3_1_15") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Major, tex);
			}else if (tex.name == "3_1_16") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.LieutenantColonel, tex);
			}else if (tex.name == "3_1_17") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.Colonel, tex);
			}else if (tex.name == "3_1_18") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.BrigadierGeneral, tex);
			}else if (tex.name == "3_1_19") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.MajorGeneral, tex);
			}else if (tex.name == "3_1_20") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.LieutenantGeneral, tex);
			}else if (tex.name == "3_1_21") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.General, tex);
			}else if (tex.name == "3_1_22") {
				SOVIETFaction.Ranks.Add (Character.C_Rank.GeneralOfTheArmy, tex);
			}
		}
	}
}
