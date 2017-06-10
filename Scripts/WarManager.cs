using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WarManager : MonoBehaviour {
	public static WarManager WM;

	private static GameControl GC = GameControl.control;
	private static CostAndPrices CP = CostAndPrices.CAP;
	private static FactionManager FM = FactionManager.control;
	public Dictionary<int, WARData> WarList = new Dictionary<int, WARData> ();

	int counter;

	public int DeployCounter = 0;
	public int war; 
	public int wlc;
	private DateTime Today = DateTime.Today;
	public int wc;
	public Text warcount;
	public Dropdown warSelect;
	public RawImage faction;
	private int selectedWar;
	public Texture us;
	public Texture germ;
	public Texture sov;

	void Awake(){
		// only one instance allowed
		if (WM == null) {
			//DontDestroyOnLoad (gameObject);
			WM = this;
		} else if (WM != this) {
			Destroy (gameObject);
		}



	}
	// Use this for initialization
	void Start () {
		setOptionList ();
		GameControl GC = GameControl.control;
		CostAndPrices CP = CostAndPrices.CAP;
		FactionManager FM = FactionManager.control;
		counter = GC.warCount;
		setSelectedWar ();
	}
	
	// Update is called once per frame
	void Update () {
		war = GameControl.control.warCount;
		wlc = WarList.Count;
		if (selectedWar <= 1){
			selectedWar = GameControl.control.warCount;
			wc = selectedWar;
			//warcount.text = selectedWar.ToString();
		}

		if (GameControl.control.CurrentFaction == "US") {
			faction.texture = us;
		} else if (GameControl.control.CurrentFaction == "GERMANY") {
			faction.texture = germ;
		} else if (GameControl.control.CurrentFaction == "SOVIET") {
			faction.texture = sov;
		} else {
			return;
		}

	}

	public void setSelectedWar(){
		if (GameControl.control.IsFirstTimeRun == true) {
			return;
		}

		selectedWar = int.Parse (warSelect.captionText.text);
		GameControl.control.Credits = WarList [selectedWar].CurCredit;
		GameControl.control.Warfunds = WarList [selectedWar].CurWarfunds;
		GameControl.control.Gold = WarList [selectedWar].CurGold;
		warcount.text = selectedWar.ToString();
	}

	public void setOptionList()

	{
		List<string> lst = new List<string>();
		foreach (KeyValuePair<int, WARData> wd in WarList) {
			lst.Add (wd.Key.ToString ());
		}
		warSelect.ClearOptions ();
		warSelect.AddOptions (lst);
	}

	public void ResetForWar(string sfact){
		if (FactionManager.control.Factions [sfact].AssaultTeams.Count == 0) {
			return;
		} else {
			foreach (AssaultTeam at in FactionManager.control.Factions[sfact].AssaultTeams) {
				at.readyForDeploy = false;
				at.setForDeploy = false;
				at.IsDeployed = false;
				at.IsActive = false;
				at.deployID = 0;
				at.Owner_ID = 0;
				at.ViewerID = 0;
			}

			DeployCounter = 0;
		}





	}

	public void NewWar(){
		ResetForWar ("US");
		ResetForWar ("GERMANY");
		ResetForWar ("SOVIET");

		EndWar ();


		CharacterManager.characterManager.ResetPanel ();
		CharacterManager.characterManager.DisplayCharacter (GameControl.control.CurrentFaction);

		ATmanager.atManager.ResetAll ();
		ATmanager.atManager.ShowAT(GameControl.control.CurrentFaction);

		foreach(Character c in FactionManager.control.Factions["US"].Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}
		foreach(Character c in FactionManager.control.Factions["GERMANY"].Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}
		foreach(Character c in FactionManager.control.Factions["SOVIET"].Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}


		foreach(Character c in FactionManager.control.USFaction.Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}
		foreach(Character c in FactionManager.control.GERMANFaction.Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}
		foreach(Character c in FactionManager.control.SOVIETFaction.Characters){
			//c.AssaultTeamsDeployed.Clear();
			c.CommandActivePoints = c.CommandPoints;
			c.hasDeploy = false;
			c.hasSavedDeploy = false;
		}

		DeployCounter = 0;
		ClearDeploys ();
		SetFaction ();

	}

	void ClearDeploys(){
		FactionManager.control.Factions ["US"].AssaultTeamsdeployed.Clear ();
		FactionManager.control.Factions ["GERMANY"].AssaultTeamsdeployed.Clear ();
		FactionManager.control.Factions ["SOVIET"].AssaultTeamsdeployed.Clear ();
		GameControl.control.USdeployed.Clear ();
		GameControl.control.GERMdeployed.Clear ();
		GameControl.control.SOVdeployed.Clear ();
	}

	void SetFaction(){
		CanvasManager.CM.popup.SetActive (true);
		CanvasManager.CM.ok.SetActive (false);
		CanvasManager.CM.cancel.SetActive (false);
		CanvasManager.CM.message.text = "Join Faction";
		CanvasManager.CM.B_usFlag.onClick.AddListener (() => getFaction("US"));
		CanvasManager.CM.B_germFlag.onClick.AddListener (() => getFaction("GERMANY"));
		CanvasManager.CM.B_sovFlag.onClick.AddListener (() => getFaction("SOVIET"));
	}

	public void getFaction(string _faction){
		GameControl.control.CurrentFaction = _faction;
		CanvasManager.CM.popup.SetActive (false);
		StartNewWAR ();
		setOptionList ();
		//ChartManager.Chart.GetOptions ();
	}

	void StartNewWAR(){
		// reset all deploys
		//get current overall credits, warfunds, gold
		// create a new WARData()
		GameControl.control.setWarCount();
		counter = GameControl.control.warCount;
		var WD = new WARData (counter);
		WD.BeginCredit = GameControl.control.Credits;
		WD.BeginWarfunds = GameControl.control.Warfunds;
		WD.BeginGold = GameControl.control.Gold;
		WarList.Add (counter, WD);
		updateCurrency ();
		Debug.LogError ("Current WAR for Europe is " + counter + " : " + WD.GetStartTime());
	}

	void EndWar(){
		counter = GameControl.control.warCount;
		foreach (KeyValuePair<int, WARData> wd in WarList) {
			if(wd.Key == counter){
				wd.Value.EndCredit = GameControl.control.Credits;
				wd.Value.EndWarfunds = GameControl.control.Warfunds;
				wd.Value.EndGold = GameControl.control.Gold;
				wd.Value.SetEndTime ();
				wd.Value.CalculateCreditCosts ();
				wd.Value.CalculateWarfundsCosts ();
				wd.Value.CalculateGoldCosts ();
			}
			updateCurrency ();
			Debug.LogError ("Current WAR for Europe is " + counter + " : " + wd.Value.EndCredit);
		}

	}

	public void addCreditcosts(InputField t){
		
		if (GameControl.control.CheckCurrency (GameControl.control.Credits, int.Parse (t.text)) == false) {
			t.text = "";
			return;
		}

		WarList [selectedWar].CostsInCredits.Add (int.Parse(t.text));
		GameControl.control.Credits -= int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	public void addWarfundscosts(InputField t){
		
		if (GameControl.control.CheckCurrency (GameControl.control.Warfunds, int.Parse (t.text)) == false) {
			t.text = "";
			return;
		}

		WarList [selectedWar].CostsInWarfunds.Add (int.Parse(t.text));
		GameControl.control.Warfunds -= int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	public void addGoldcosts(InputField t){
		
		if (GameControl.control.CheckCurrency (GameControl.control.Gold, int.Parse (t.text)) == false) {
			t.text = "";
			return;
		}

		WarList [selectedWar].CostsInGold.Add (int.Parse(t.text));
		GameControl.control.Gold -= int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	public void BOD(){
		GameControl.control.Gold += 4;
		updateCurrency ();
	}

	public void addCredits(InputField t){
		GameControl.control.Credits += int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	public void addWarfunds(InputField t){
		GameControl.control.Warfunds += int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	public void addGold(InputField t){
		GameControl.control.Gold += int.Parse (t.text);
		t.text = "";
		updateCurrency ();
	}

	void updateCurrency(){
		WarList [selectedWar].CurCredit = GameControl.control.Credits;
		WarList [selectedWar].CurWarfunds = GameControl.control.Warfunds;
		WarList [selectedWar].CurGold = GameControl.control.Gold;
	}

}


