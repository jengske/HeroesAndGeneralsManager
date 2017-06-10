using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// these need to be added for file management works
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
// thes need to be added for working with gui elements
using UnityEngine.UI;

public class ChartManager : MonoBehaviour {
	public static ChartManager Chart;
	#region vars
	// enable faction
	public GameObject us;
	public GameObject germ;
	public GameObject sov;
	public Toggle T_US;
	public Toggle T_GERM;
	public Toggle T_SOV;
	public GameObject selectionp;
	// toggle groups
	public ToggleGroup TG_Factions;
	// toggles
	// loadsection
	public Toggle T_A;
	public Toggle T_B;
	public Toggle T_C;
	public Toggle T_D;

	// selectionsection
	public Toggle T_Credits;
	public Toggle T_Warfunds;
	public Toggle T_Gold;
	public Toggle T_CostsCredits;
	public Toggle T_CostsWarfunds;
	public Toggle T_CostsGold;
	// buttons
	public Button B_Show;
	public Button B_LoadWars;
	public Button B_ClearFields;

	// dropdowns
	public Dropdown DR_A;
	public Dropdown DR_B;
	public Dropdown DR_C;
	public Dropdown DR_D;

	// Colors
	public Color C_A;
	public Color C_B;
	public Color C_C;
	public Color C_D;

	// Graphwindow
	public GameObject selectionprefab;
	public GameObject loadprefab;
	public RectTransform selection;
	public RectTransform  loadpanel;

	// dictionary & list
	List<chartdata> Datalist = new List<chartdata>();
	public List<int> inputValues = new List<int>();

	List<string> dropDownOptions = new List<string>();
	public Dictionary<int,chartdata> CD = new Dictionary<int, chartdata>(); // cd.add(warcount, data);

	// default option
	string DefaultOption = "NONE";

	public string factionselected = "";
	#endregion

	#region System fuctions
	// System fuctions //
	void Awake(){
		GetOptions ();
	}

	// Use this for initialization
	void Start () {
		spawnLoad ();
		spawnSelect ();
		GetOptions ();
	}
	
	// Update is called once per frame
	void Update () {
		GetOptions ();
		factionselected = GameControl.control.CurrentFaction;
		if (factionselected == "US") {
			selectionp.SetActive (true);
			us.SetActive (true);
			T_US.isOn = true;
			germ.SetActive (false);
			sov.SetActive (false);
			//GetOptions ();
		} else if (factionselected == "GERMANY") {
			selectionp.SetActive (true);
			us.SetActive (false);
			germ.SetActive (true);
			T_GERM.isOn = true;
			sov.SetActive (false);
			//GetOptions ();
		} else if (factionselected == "SOVIET") {
			selectionp.SetActive (true);
			us.SetActive (false);
			germ.SetActive (false);
			sov.SetActive (true);
			T_SOV.isOn = true;
			//GetOptions ();
		} else {
			selectionp.SetActive (false);
		}
	}
	// End System fuctions //
	#endregion

	// checkers
	void CheckEmpty(){}

	// workflow
	public void GetOptions(){


		dropDownOptions.Clear();
		dropDownOptions.Add(DefaultOption);

		foreach (KeyValuePair<int, WARData> wd in WarManager.WM.WarList) {

			if(wd.Value.preferedFaction == factionselected){
				dropDownOptions.Add (wd.Key.ToString ());

			}
		}



		SetOptions ();
	}

	void SetOptions(){
		//Debug.Log ("SetOptions");
		DR_A.ClearOptions ();
		DR_A.AddOptions (dropDownOptions);
		DR_B.ClearOptions ();
		DR_B.AddOptions (dropDownOptions);
		DR_C.ClearOptions ();
		DR_C.AddOptions (dropDownOptions);
		DR_D.ClearOptions ();
		DR_D.AddOptions (dropDownOptions);
	}

	public void LoadWars(){
		int WAR_A = 0;
		int WAR_B = 0;
		int WAR_C = 0;
		int WAR_D = 0;

		if (T_A.isOn == true) {
			WAR_A = int.Parse (DR_A.captionText.text);
		} else {
			WAR_A = 0;
		}

		if(T_B.isOn == true){
			WAR_B = int.Parse(DR_B.captionText.text);
		}else {
			WAR_B = 0;
		}

		if(T_C.isOn == true){
			WAR_C = int.Parse(DR_C.captionText.text);
		}else {
			WAR_C = 0;
		}

		if(T_D.isOn == true){
			WAR_D = int.Parse(DR_D.captionText.text);
		}else {
			WAR_D = 0;
		}

		Datalist.Clear ();

		foreach (KeyValuePair<int, WARData> wd in WarManager.WM.WarList) {
			if(wd.Key == WAR_A){
				chartdata data = new chartdata ();
				data.credits = wd.Value.EndCredit;
				data.warcount = wd.Key;
				data.warfunds = wd.Value.EndWarfunds;
				data.gold = wd.Value.EndGold;
				data.c_credits = wd.Value.TotalCreditCosts;
				data.c_warfunds = wd.Value.TotalWarfundsCosts;
				data.c_gold = wd.Value.TotalGoldCosts;

				data.displayColor = C_A;


				Datalist.Add (data);
				Debug.LogError ("Datalist.Add (data) " + wd.Key + " check: " + data.credits);
			}

			if( wd.Key == WAR_B){
				chartdata data = new chartdata ();
				data.credits = wd.Value.EndCredit;
				data.warcount = wd.Key;
				data.warfunds = wd.Value.EndWarfunds;
				data.gold = wd.Value.EndGold;
				data.c_credits = wd.Value.TotalCreditCosts;
				data.c_warfunds = wd.Value.TotalWarfundsCosts;
				data.c_gold = wd.Value.TotalGoldCosts;

				data.displayColor = C_B;


				Datalist.Add (data);
				Debug.LogError ("Datalist.Add (data) " + wd.Key + " check: " + data.credits);
			}

			if(wd.Key == WAR_C){
				chartdata data = new chartdata ();
				data.credits = wd.Value.EndCredit;
				data.warcount = wd.Key;
				data.warfunds = wd.Value.EndWarfunds;
				data.gold = wd.Value.EndGold;
				data.c_credits = wd.Value.TotalCreditCosts;
				data.c_warfunds = wd.Value.TotalWarfundsCosts;
				data.c_gold = wd.Value.TotalGoldCosts;

				data.displayColor = C_C;


				Datalist.Add (data);
				Debug.LogError ("Datalist.Add (data) " + wd.Key + " check: " + data.credits);
			}

			if(wd.Key == WAR_D){
				chartdata data = new chartdata ();
				data.credits = wd.Value.EndCredit;
				data.warcount = wd.Key;
				data.warfunds = wd.Value.EndWarfunds;
				data.gold = wd.Value.EndGold;
				data.c_credits = wd.Value.TotalCreditCosts;
				data.c_warfunds = wd.Value.TotalWarfundsCosts;
				data.c_gold = wd.Value.TotalGoldCosts;

				data.displayColor = C_D;


				Datalist.Add (data);
				Debug.LogError ("Datalist.Add (data) " + wd.Key + " check: " + data.credits);
			}
		}	

		reset ();
		spawnLoad ();
		spawnSelect ();

	}

	public void SelectData(){
		

		BarChart.BAR.inputValues.Clear ();
		if(T_Credits.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {
				
				BarChart.BAR.inputValues.Add(Datalist[i].credits);
				BarChart.BAR.labels.Add(i + "_Credits");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}

		}

		if(T_Warfunds.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {

				BarChart.BAR.inputValues.Add(Datalist[i].warfunds);
				BarChart.BAR.labels.Add(i + "_Warfunds");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}
		}

		if(T_Gold.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {

				BarChart.BAR.inputValues.Add(Datalist[i].gold);
				BarChart.BAR.labels.Add(i + "_Gold");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}
		}

		if(T_CostsCredits.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {

				BarChart.BAR.inputValues.Add(Datalist[i].c_credits);
				BarChart.BAR.labels.Add(i + "_CostsCredits");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}
		}

		if(T_CostsWarfunds.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {

				BarChart.BAR.inputValues.Add(Datalist[i].c_warfunds);
				BarChart.BAR.labels.Add(i + "_CostsWarfunds");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}
		}

		if(T_CostsGold.isOn == true){
			for (int i = 0; i < Datalist.Count; i++) {

				BarChart.BAR.inputValues.Add(Datalist[i].c_gold);
				BarChart.BAR.labels.Add(i + "_CostsGold");
				BarChart.BAR.colors.Add(Datalist[i].displayColor);
			}
		}

		BarChart.BAR.DisplayGraph(BarChart.BAR.inputValues);
		foreach (int t in BarChart.BAR.inputValues) {
			Debug.Log (t);
		}
	}

	void spawnSelect(){
		GameObject sel = Instantiate(selectionprefab) as GameObject;
		sel.transform.SetParent (selection.transform);
		GetOptions ();
	}

	void spawnLoad(){
		GameObject lo = Instantiate(loadprefab) as GameObject;
		lo.transform.SetParent (loadpanel);
		GetOptions ();
	}

	void reset(){
		ATmanager.atManager.ResetPanel (selection);
		ATmanager.atManager.ResetPanel (loadpanel);
	}
}

public class chartdata{
	public int warcount;

	public string faction;

	public Color displayColor;

	public int credits;

	public int warfunds;

	public int gold;

	public int c_credits;

	public int c_warfunds;

	public int c_gold;

}