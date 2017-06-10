using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// these need to be added for file management works
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
// thes need to be added for working with gui elements
using UnityEngine.UI;

public class SaveAndLoad : MonoBehaviour {
	public static SaveAndLoad sal;
	//private List<string> SavedSessions = new List<string> ();
	private string filePath;
	public Dictionary<string, string> td;
	// GUI elements
//	public Text tt;
//	public Text counter;
//	public Text debug;
//	public Dropdown drop; // _options will be displayed and used.
	// dropdown options
//	private readonly List<string> _options = new List<string>();
	// list of SavedGame files
	public Dictionary<DateTime,PlayerData> SavedGame = new Dictionary<DateTime,PlayerData> ();
	// counter for testing only
	int c;


	public void Save () {
		if (!Directory.Exists (Application.persistentDataPath + "/SavedData/")) {
			Directory.CreateDirectory (Application.persistentDataPath + "/SavedData/");
		} 

		filePath = Application.persistentDataPath + "/SavedData/SaveGame_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".4THID";

		if (!File.Exists (filePath)) {
			Debug.Log ("No File found");
		}

		GameControl.control.SetCharData ();
		GameControl.control.SetATData ();
		Debug.Log ("save 1");
		BinaryFormatter binary = new BinaryFormatter ();
		Debug.Log ("save 2");
		FileStream fstream = File.Create (filePath);
		Debug.Log ("save 3");
		PlayerData PD = new PlayerData ();
		Debug.Log ("save 4");
		PD.isDebugging = GameControl.control.IsDebugging;
		PD.isFirstTimeRun = GameControl.control.IsFirstTimeRun;
		PD.isSaved = GameControl.control.IsSaved;
//		// Currency data
		PD.credits = GameControl.control.Credits;
		PD.warfunds = GameControl.control.Warfunds;
		PD.gold = GameControl.control.Gold;
//		// Player data
		PD.clanName = GameControl.control.clanName;
		PD.inGameName = GameControl.control.inGameName;
		PD.warCount = GameControl.control.warCount;
	
		PD.currentfaction = GameControl.control.CurrentFaction;
		PD.US_AssaultTeamsdeployed = FactionManager.control.USFaction.AssaultTeamsdeployed;
		PD.GERMAN_AssaultTeamsdeployed = FactionManager.control.GERMANFaction.AssaultTeamsdeployed;
		PD.SOVIET_AssaultTeamsdeployed = FactionManager.control.SOVIETFaction.AssaultTeamsdeployed;
//		// Factions
//		
		Debug.Log ("save 5");
//
//		// Faction storage




		PD.SavedGames = SavedGame;
//

		PD.war = WarManager.WM.war;
		PD.wlc = WarManager.WM.wlc;
		PD.wc = WarManager.WM.wc;
		PD.DeployCounter = WarManager.WM.DeployCounter;
		PD.WarList = WarManager.WM.WarList;

		PD.Characters = GameControl.control.S_Characterdata;
		PD.Assaultteams = GameControl.control.S_ATdata;

		PD.USdeployed = GameControl.control.USdeployed;
		PD.GERMdeployed = GameControl.control.GERMdeployed;
		PD.SOVdeployed = GameControl.control.SOVdeployed;


		Debug.Log ("save 6");
		binary.Serialize (fstream, PD);
		Debug.Log ("save 7");

		//SavedSessions.Add (filePath);
		//PD.SavedSessions = SavedSessions;
		GameControl.control.Totalsaved++;
		PD.Totalsaved = GameControl.control.Totalsaved;
		SavedGame.Add (DateTime.Now, PD);
		GameControl.control.IsSaved = true;
		fstream.Close ();

		Debug.Log ("ending save");
		// status msg
		//StartCoroutine (saving (fs.time));
		//check (Application.persistentDataPath + "/SaveGame_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".4THID");
	}

	// status mgs section
//	IEnumerator saving(DateTime tst){
//		debug.text = "Saving " + tst;
//		yield return new WaitForSeconds (2);
//		debug.text = "";
//		//drop.AddOptions (_options);
//		GetFiles();
//	}
//
//	IEnumerator Loading(DateTime cc){
//		debug.text = "Loading " + cc;
//		yield return new WaitForSeconds (2);
//		debug.text = "";
//	}
//
//	IEnumerator adding(){
//		debug.text = "Adding a record to the list " ;
//		yield return new WaitForSeconds (2);
//		debug.text = "";
//	}
	/// <summary>
	/// check code
	/// </summary>
	public void FirstTimeLoad(){
		if (Directory.Exists (Application.persistentDataPath + "/SavedData/")) {
			var info = new DirectoryInfo (Application.persistentDataPath + "/SavedData/");
			var fileInfo = info.GetFiles ();
			List<string> tmp = new List<string> ();

			foreach (string file in System.IO.Directory.GetFiles(Application.persistentDataPath + "/SavedData/")) {
				Debug.Log (file);
				tmp.Add (file);
			}
			if (tmp.Count <= 0) {
				Load (tmp [0]);
			} else {
				//fout melding
				Load (tmp[tmp.Count-1]);
			}

		}
	}


	public void Load (string _file) {
		Debug.Log ("Loading: " + _file);
		if(File.Exists(_file)){
			BinaryFormatter binary = new BinaryFormatter ();
			FileStream fstream = File.Open (_file, FileMode.Open);

			PlayerData pd = (PlayerData)binary.Deserialize (fstream);
			fstream.Close ();

			GameControl.control.IsDebugging = pd.isDebugging;
			GameControl.control.IsFirstTimeRun = pd.isFirstTimeRun;
			GameControl.control.IsSaved = pd.isSaved;
			// Currency data
			GameControl.control.Credits = pd.credits;
			GameControl.control.Warfunds = pd.warfunds;
			GameControl.control.Gold = pd.gold;
			// Player data
			GameControl.control.clanName = pd.clanName;
			GameControl.control.inGameName = pd.inGameName;
			GameControl.control.warCount = pd.warCount;
			//
			GameControl.control.CurrentFaction = pd.currentfaction;

			//SavedSessions = pd.SavedSessions;
			GameControl.control.Totalsaved = pd.Totalsaved;
			SavedGame = pd.SavedGames;
			//

			WarManager.WM.war = pd.war;
			WarManager.WM.wlc = pd.wlc;
			WarManager.WM.wc = pd.wc;

			if(pd.USdeployed == null){pd.USdeployed = new Dictionary<string, int> ();}
			foreach(KeyValuePair<string, int> d in pd.USdeployed){
				GameControl.control.USdeployed.Add (d.Key, d.Value);
			}
			if(pd.GERMdeployed == null){pd.GERMdeployed = new Dictionary<string, int> ();}
			foreach(KeyValuePair<string, int> d in pd.GERMdeployed){
				GameControl.control.GERMdeployed.Add (d.Key, d.Value);
			}
			if(pd.SOVdeployed == null){pd.SOVdeployed = new Dictionary<string, int> ();}
			foreach(KeyValuePair<string, int> d in pd.SOVdeployed){
				GameControl.control.SOVdeployed.Add (d.Key, d.Value);
			}

			foreach(KeyValuePair<int,WARData> d in pd.WarList){
				WarManager.WM.WarList.Add (d.Key, d.Value);
			}

			foreach(CharacterData d in pd.Characters){
				GameControl.control.S_Characterdata.Add (d);
			}

			foreach(ATData d in pd.Assaultteams){
				GameControl.control.S_ATdata.Add (d);
			}

			FactionManager.control.USFaction.AssaultTeamsdeployed = pd.US_AssaultTeamsdeployed;
			FactionManager.control.GERMANFaction.AssaultTeamsdeployed = pd.GERMAN_AssaultTeamsdeployed;
			FactionManager.control.SOVIETFaction.AssaultTeamsdeployed = pd.SOVIET_AssaultTeamsdeployed;
			//StartCoroutine (Loading (fs.time));
			GameControl.control.GetCharData();
			GameControl.control.GetATData();

			WarManager.WM.WarList = pd.WarList;
			WarManager.WM.DeployCounter = pd.DeployCounter;
			WarManager.WM.setOptionList ();


			Debug.Log ("Loaded");
		}
	}

//  // for loading from a list
//	public void LoadFile(){
//		//check (drop.captionText.text.ToString());
//		Load (Application.persistentDataPath.ToString() + "/" + drop.captionText.text.ToString());
//	}

	void Awake(){
		if (sal == null) {
			DontDestroyOnLoad (gameObject);
			sal = this;
		}
		//set the dropdown options before Start
		//GetFiles ();

		filePath = Application.persistentDataPath + "/SavedData/SaveGame_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".4THID";
	}

	// update the dropdown to the files from a directory
//	void GetFiles(){
//		_options.Clear ();
//		foreach(string s in Directory.GetFiles(Application.persistentDataPath )){
//
//			_options.Add (Path.GetFileName (s));
//			drop.ClearOptions ();
//			drop.AddOptions (_options);
//			//Debug.Log (Path.GetFileName (s));
//		}
//
//	}

	void Start(){
		filePath = Application.persistentDataPath + "/SavedData/SaveGame_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".4THID";
		td = new Dictionary<string, string>();
		c = td.Count;
		//GetFiles();


		//Debug.Log (Application.persistentDataPath + "/SaveGame_" + DateTime.Now.Day.ToString () + DateTime.Now.Month.ToString () + DateTime.Now.Year.ToString () + "_" + DateTime.Now.Hour.ToString () + DateTime.Now.Minute.ToString () + DateTime.Now.Second.ToString () + ".4THID");
	}

	void Update(){
//		tt.text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
//		counter.text = c.ToString();
	
	}


	// test code to look if save/load is working
	public void addstring(string k, string v){
		td.Add (k, v);
	}

	public void adds(){
		c++;
		///StartCoroutine (adding());
		addstring ("test" + c.ToString(), "test");

		//Debug.Log (td.Count.ToString());
	}

	void check(string fstream){
		if (Directory.Exists (Application.persistentDataPath)) {
			
			if (File.Exists (fstream)) {
				Debug.Log("exists");
			}
		}
	}
}
