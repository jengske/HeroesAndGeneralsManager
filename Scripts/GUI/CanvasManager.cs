using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {
	public static CanvasManager CM;
	// we use canvas toggle
	public RectTransform FirstTimeRun;
	public bool FTRActive = true;
	// info panel
	public RectTransform Info;
	public bool InfoActive = false;
	// main panel
	public Canvas MainCanvas;
	public RectTransform Main;
	public bool MainActive = false;
	// Character panel
	public RectTransform Characters;
	public bool CharactersActive = false;
	//Assault team panel
	public RectTransform AssaultTeams;
	public bool AssaultTeamsActive = false;
	// WAR/Deploy panel
	public RectTransform War;
	public bool WarActive = false;
	// Factions panel
	public RectTransform Factions;
	public bool FactionsActive = false;

	public RectTransform Deploys;
	public bool DeploysActive = false;

	public RectTransform Graph;
	public bool GraphActive = false;

	public RectTransform Profile;
	public bool ProfileActive = false;

	// creditbar
	public RectTransform CreditBar;
	public bool CreditBarActive = false;

	public RectTransform Settings;
	public bool SettingsActive = false;

	// navigation bars
	public RectTransform HorizontalNavBar;
	public bool HorizontalNavBarActive = false;

	/// popup window /// 
	// elements we need to disply or hide
	public GameObject popup;
	public GameObject usFlag;
	public GameObject germFlag;
	public GameObject sovFlag;
	public GameObject ok;
	public GameObject cancel;

	public Button B_usFlag;
	public Button B_germFlag;
	public Button B_sovFlag;
	public Button B_Ok;
	public Button B_Cancel;

	public Text message;
	// debug and error panels

	void Awake(){
		if (CM == null) {
			DontDestroyOnLoad (gameObject);
			CM = this;
		} else if (CM != this) {
			Destroy (gameObject);
		}
			
	}



	// Use this for initialization
	void Start () {
		popup.SetActive (false);
		Screen.SetResolution (1024, 768, true);
		MainMenu ();
		if (GameControl.control.IsFirstTimeRun) {
			if (GameControl.control.IsDebugging) {
				Debug.Log ("First Time run On");
				FirstTimeRun.gameObject.SetActive (true);
			}

			//FirstTimeRun ();
		} else if(!GameControl.control.IsFirstTimeRun){
			FirstTimeRun.gameObject.SetActive (false);
		MainMenu ();
		}
		
	}

	// Update is called once per frame
	void Update () {
		if(FTRActive == true){
			FirstTimeRun.gameObject.SetActive (true);
			MainCanvas.gameObject.SetActive (false);
			//GameControl.control.IsFirstTimeRun = true;
		}else {
			FirstTimeRun.gameObject.SetActive (false);
			MainCanvas.gameObject.SetActive (true);
		}

		FTRActive = GameControl.control.IsFirstTimeRun;

			if (InfoActive == true) {
				Info.gameObject.SetActive(true);
			} else {
				Info.gameObject.SetActive (false);
			}

			if (MainActive == true) {
				Main.gameObject.SetActive(true);
			} else {
				Main.gameObject.SetActive (false);
			}

			if (CharactersActive == true) {
				Characters.gameObject.SetActive (true);
			} else {
				Characters.gameObject.SetActive (false);
			}
			if (AssaultTeamsActive == true) {
				AssaultTeams.gameObject.SetActive (true);
			} else {
				AssaultTeams.gameObject.SetActive (false);
			}
			if (DeploysActive == true) {
				Deploys.gameObject.SetActive (true);
			} else {
				Deploys.gameObject.SetActive (false);
			}
			if (WarActive == true) {
				War.gameObject.SetActive (true);
			} else {
				War.gameObject.SetActive (false);
			}

			if (FactionsActive == true) {
				Factions.gameObject.SetActive (true);
			} else {
				Factions.gameObject.SetActive (false);
			}

			if (GraphActive == true) {
				Graph.gameObject.SetActive (true);
			} else {
				Graph.gameObject.SetActive (false);
			}
			if (ProfileActive == true) {
				Profile.gameObject.SetActive (true);
			} else {
				Profile.gameObject.SetActive (false);
			}

			if (SettingsActive == true) {
				Settings.gameObject.SetActive (true);
			} else {
				Settings.gameObject.SetActive (false);
			}
			// creditbar
		if (CreditBarActive == true) {
			CreditBar.gameObject.SetActive(true);
			} else {
			CreditBar.gameObject.SetActive (false);
			}
			// navigation
			if (HorizontalNavBarActive == true) {
				HorizontalNavBar.gameObject.SetActive(true);
			} else {
				HorizontalNavBar.gameObject.SetActive (false);
			}

//			if (VerticalNavBarActive == true) {
//				VerticalNavBar.gameObject.SetActive(true);
//			} else {
//				VerticalNavBar.gameObject.SetActive (false);
//			}
	


	}

	// Button events for the menu's
	public void InfoMenu() {
		InfoActive = true;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;
		//VerticalNavBarActive = false;
	}

	public void MainMenu() {
		InfoActive = false;
		MainActive = true;
		CreditBarActive = false;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = true;
		//VerticalNavBarActive = false;
	}

	public void CharacterMenu() {
		CharacterManager.characterManager.ResetPanel ();
		CharacterManager.characterManager.DisplayCharacter (GameControl.control.CurrentFaction);
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = true;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void AssaultTeamMenu() {
		ATmanager.atManager.ResetAll ();
		ATmanager.atManager.ShowAT(GameControl.control.CurrentFaction);
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = true;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void WarMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = true;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void FactionsMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = true;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void DeploysMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = true;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void GraphMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = true;
		ProfileActive = false;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void ProfileMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = true;
		SettingsActive = false;

		HorizontalNavBarActive = false;

	}

	public void SettingsMenu() {
		InfoActive = false;
		MainActive = false;
		CreditBarActive = true;
		CharactersActive = false;
		AssaultTeamsActive = false;
		FactionsActive = false;
		WarActive = false;
		DeploysActive = false;
		GraphActive = false;
		ProfileActive = false;
		SettingsActive = true;

		HorizontalNavBarActive = false;

	}

	public void OnQuit(){
		SaveAndLoad.sal.Save ();
		Application.Quit();
	}


}
