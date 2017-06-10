/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// CharacterManager.cs
/// 
/// </summary>
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <ToDo>
/// check display code.
/// </ToDo>

public class CharacterManager : MonoBehaviour {
	// reference the instance
	public static CharacterManager characterManager;
	// Display/ Gui elements //
	// prefabs
	public CharacterHolder CharacterPrefab;
	public GameObject IMGHolder;
	public GameObject BuyCharPrefab;

	public RectTransform buttonspanel;
	public RectTransform spawnpanel;
	public RectTransform spawnpanel2;
	public RectTransform buyPanel;

	// chartHeight needed to calculate the barHeights
	float chartHeight;

//	public Text _Name;
//	public InputField _IName;
//	public Dropdown _Faction;
//	public Dropdown _Rank;
//	public Dropdown _Career;
//
//	// Display selected
//	public Text costsCred;
//	public Text costsGold;

	/// <summary>
	/// Carreer images
	/// </summary>
	// US
	// Infantry
	public Texture USInf;
	// Para
	public Texture USPara;
	// Recon
	public Texture USRecon;
	// Tanker
	public Texture USTank;
	// Pilot
	public Texture USPilot;
	// General
	public Texture USGeneral;

	// GERMANY
	// Infantry
	public Texture GERMInf;
	// Para
	public Texture GERMPara;
	// Recon
	public Texture GERMRecon;
	// Tanker
	public Texture GERMTank;
	// Pilot
	public Texture GERMPilot;
	// General
	public Texture GERMGeneral;

	// SOVIET
	// Infantry
	public Texture SOVInf;
	// Para
	public Texture SOVPara;
	// Recon
	public Texture SOVRecon;
	// Tanker
	public Texture SOVTank;
	// Pilot
	public Texture SOVPilot;
	// General
	public Texture SOVGeneral;
	//
	public int CharCount=0;
	//
	public Dictionary<int, Character> CharacterList;

	// runs before Start()
	void Awake () {
		// only one instance allowed
		if (characterManager == null) {
			//DontDestroyOnLoad (gameObject);
			characterManager = this;
		} else if (characterManager != this) {
			Destroy (gameObject);
		}

	}
	void Start(){
		//FTR ();
//		newGeneral("US");
//				newGeneral("GERMANY");
//				newGeneral("SOVIET");
		DisplayCharacter (GameControl.control.CurrentFaction);
	}



	#region Default create
	// Create new character
	public void newInfantry(string sfact){
		CharCount++;
		Character inf = new Infantry (sfact);
		inf.C_DeployID = CharCount;
		inf.CharPanel = CharacterPrefab;
		inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		inf.RankIcon = FactionManager.control.getRankIcon(inf.Rank.ToString());

		FactionManager.control.Factions [sfact].Characters.Add (inf);
		FactionManager.control.Factions [sfact].TotalOwnedCharInf += 1;

		////Debug.Log ("A New " + sfact + " Infantry is added. id:_" + inf.C_ID.ToString());
	}

	public void newPara(string sfact)
	{
		Character par = new Para (sfact);
		CharCount++;
		par.C_DeployID = CharCount;
		par.CharPanel = CharacterPrefab;
		par.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		par.RankIcon = FactionManager.control.getRankIcon(par.Rank.ToString());
		FactionManager.control.Factions [sfact].Characters.Add (par);
		FactionManager.control.Factions [sfact].TotalOwnedCharPar += 1;
		////Debug.Log ("A New " + sfact + " Para is added. id:_" + par.C_ID.ToString());
	}

	public void newRecon(string sfact)
	{
		Character rec = new Recon (sfact);
		CharCount++;
		rec.C_DeployID = CharCount;
		rec.CharPanel = CharacterPrefab;
		rec.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		rec.RankIcon = FactionManager.control.getRankIcon(rec.Rank.ToString());
		FactionManager.control.Factions [sfact].Characters.Add (rec);
		FactionManager.control.Factions [sfact].TotalOwnedCharRec += 1;

		////Debug.Log ("A New " + sfact + " Recon is added. id:_" + rec.C_ID.ToString());
	}

	public void newPilot(string sfact)
	{
		Character pil = new Pilot (sfact);
		CharCount++;
		pil.C_DeployID = CharCount;
		pil.CharPanel = CharacterPrefab;
		pil.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		pil.RankIcon = FactionManager.control.getRankIcon(pil.Rank.ToString());
		FactionManager.control.Factions [sfact].Characters.Add (pil);
		FactionManager.control.Factions [sfact].TotalOwnedCharPil += 1;
		////Debug.Log ("A New " + sfact + " Pilot is added. id:_" + pil.C_ID.ToString());
	}

	public void newTankman(string sfact)
	{
		Character tan = new Tankman (sfact);
		CharCount++;
		tan.C_DeployID = CharCount;
		tan.CharPanel = CharacterPrefab;
		tan.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		tan.RankIcon = FactionManager.control.getRankIcon(tan.Rank.ToString());
		FactionManager.control.Factions [sfact].Characters.Add (tan);
		FactionManager.control.Factions [sfact].TotalOwnedCharTan += 1;
		////Debug.Log ("A New " + sfact + " Tankman is added. id:_" + tan.C_ID.ToString());
	}

	public void newGeneral(string sfact)
	{
		Character gen = new General (sfact);
		CharCount++;
		gen.C_DeployID = CharCount;
		gen.CharPanel = CharacterPrefab;
		gen.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
		gen.RankIcon = FactionManager.control.getRankIcon(gen.Rank.ToString());
		gen.setCommandPoints();
		FactionManager.control.Factions [sfact].Characters.Add (gen);
		FactionManager.control.Factions [sfact].TotalOwnedCharGen += 1;
		////Debug.Log ("A New " + sfact + " General is added. id:_" + gen.C_ID.ToString());
	}

	#endregion

	#region display characters
	public void ResetPanel(){
		// first clean the panel
		var children = new List<GameObject> ();
		foreach (Transform child in spawnpanel.transform) {
			children.Add (child.gameObject);
			////Debug.Log (child.name);
		}
		if (children.Count > 0) {
			children.ForEach (child => Destroy (child));
		}

		var children2 = new List<GameObject> ();
		foreach (Transform child2 in spawnpanel2.transform) {
			children2.Add (child2.gameObject);
			////Debug.Log (child.name);
		}
		if (children2.Count > 0) {
			children2.ForEach (child2 => Destroy (child2));
		}
	}

	// Display characters
	public void DisplayCharacter(string sfact){
		if (sfact == "") {
			return;
		}
		// first clean the panel
		var children = new List<GameObject> ();
		foreach (Transform child in spawnpanel.transform) {
			children.Add (child.gameObject);
			////Debug.Log (child.name);
		}
		if (children.Count > 0) {
			children.ForEach (child => Destroy (child));
		}

		var children2 = new List<GameObject> ();
		foreach (Transform child2 in spawnpanel2.transform) {
			children2.Add (child2.gameObject);
			////Debug.Log (child.name);
		}
		if (children2.Count > 0) {
			children2.ForEach (child2 => Destroy (child2));
		}
		// show the list
		//if (FactionManager.control.Factions["US"] == null){//Debug.Log("nothing found");}

		foreach (Character ch in FactionManager.control.Factions [sfact].Characters) {
			Character chc = ch;
			//GameObject go = new GameObject ();
			GameObject go = Instantiate(IMGHolder) as GameObject;
			go.name = ch.C_Name;
			go.GetComponent<getimage> ().img.texture = ch.C_Image;
			//go.AddComponent<RawImage> ();
			//go.GetComponent<RawImage> ().texture = ch.C_Image;
			//go.AddComponent<Button> ();
			go.GetComponent<Button> ().onClick.AddListener (() => ShowChar(ch.CharPanel, chc, sfact));
			go.transform.SetParent (spawnpanel2.transform);
			////Debug.Log (ch.CommandPoints.ToString ());
			//ch.setCommandPoints();
		}

		}

	public void ShowChar(CharacterHolder ch, Character cc, string sfact){
		cc.setCommandPoints ();

		var children2 = new List<GameObject> ();
		foreach (Transform child2 in spawnpanel.transform) {
			children2.Add (child2.gameObject);
			////Debug.Log (child.name);
		}
		if (children2.Count > 0) {
			children2.ForEach (child2 => Destroy (child2));
		}

		CharacterHolder newChar = Instantiate (ch) as CharacterHolder;
		//				// set to parent
		newChar.transform.SetParent(spawnpanel.transform);
		newChar.CharacterName.text = cc.getName();
						
						// set characterRank
						cc.setRankIcon(sfact);
						newChar.CharacterRank.texture = FactionManager.control.Factions [sfact].Ranks [cc.Rank];;
						newChar.CharacterRankName.text = cc.Rank.ToString();
		
						// set character Type: infantry, recon, tanker, pilot, general
					if(cc.Rank== Character.C_Rank.BrigadierGeneral){
						cc.Type = Character.C_Type.General;
						newChar.CharacterType.text = cc.Type.ToString();
		
						if (sfact == "US") {
							cc.C_Image = USGeneral;
						} else if (sfact == "GERMANY") {
							cc.C_Image = GERMGeneral;
						} else if (sfact == "SOVIET") {
							cc.C_Image = SOVGeneral;
						}
		
						newChar.CharacterImage.texture = cc.C_Image;
					}else{
						newChar.CharacterType.text = cc.Type.ToString();
						newChar.CharacterImage.texture = cc.C_Image;
		
					}
						
		
						// set characterFaction
						newChar.CharacterFaction.texture = Resources.Load<Texture> ("Images/FactionFlags/" + sfact);
						// set character assault teams
		
						//newChar.assault_teams = soldier.DeployList;
		
					newChar.CharacterUpgrade.onClick.AddListener(() => cc.updateRank());
					//newChar.CharacterUpgrade.onClick.AddListener (() => cc.UIUpdate());
					cc.setRankIcon (sfact);

					if (cc.Type == Character.C_Type.General) {
						newChar.CharacterCareerSwitch.gameObject.SetActive (false);
						newChar.cSwitch.gameObject.SetActive (false);
						newChar.ToggleGold.gameObject.SetActive (false);
			if(cc.Rank == Character.C_Rank.GeneralOfTheArmy){
				newChar.CharacterUpgrade.gameObject.SetActive (false);
			}

					} else {
						newChar.CharacterCareerSwitch.onClick.AddListener (() => cc.SwitchCareer (sfact, newChar.cSwitch.captionText.text, newChar.ToggleGold.isOn));
						//newChar.CharacterCareerSwitch.onClick.AddListener (() => cc.UIUpdate());
						//ch.UIUpdate ();
					}

				newChar.EditEnd.onClick.AddListener (() => cc.setName(newChar.Rename.text));
				//newChar.EditEnd.onClick.AddListener (() => cc.UIUpdate());



	}

	public void DestroyObj(GameObject go){
		Destroy (go);
	}

	public void ShowBuy(){
		GameObject go = Instantiate (BuyCharPrefab) as GameObject;
		go.transform.SetParent (buyPanel.transform);
		go.GetComponent<buyChar>().creds.onClick.AddListener(() => buyPanel.gameObject.SetActive(false));
		go.GetComponent<buyChar>().creds.onClick.AddListener(() => DestroyObj(go));

		go.GetComponent<buyChar>().gold.onClick.AddListener(() => buyPanel.gameObject.SetActive(false));
		go.GetComponent<buyChar>().gold.onClick.AddListener(() => DestroyObj(go));

		go.GetComponent<buyChar>().close.onClick.AddListener(() => buyPanel.gameObject.SetActive(false));
	}
	#endregion
}
	