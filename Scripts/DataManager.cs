using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DataManager : MonoBehaviour {
	public static DataManager DM;
	public string _faction;
	public Dictionary<int, int> cIDcACP = new Dictionary<int, int>();
	public int interval = 5;

	private bool isRunning = false;

	void Awake () {
		// only one instance allowed
		if (DM == null) {
			//DontDestroyOnLoad (gameObject);
			DM = this;
		} else if (DM != this) {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F2)){
			CheckDictionairies ();
		}

		if(Input.GetKeyDown(KeyCode.F3)){
			CheckDeployStatics();
		}
	}
	// 
	// checking
	void CheckDeployStatics(){
		int a;
		int b;

		foreach(Character c in FactionManager.control.USFaction.Characters){
			foreach(Character cf in FactionManager.control.Factions["US"].Characters){
				if(c.CommandPoints > 0 && cf.CommandPoints > 0 && c.CommandActivePoints == cf.CommandActivePoints){
					Debug.LogWarning ("DataManager CHECK " + c.C_Name + " US Active commandpoints = Passed");
					Debug.LogWarning ("DataManager CHECK " + c.CommandActivePoints + " - " + cf.CommandActivePoints);
				}else{
					Debug.LogWarning ("DataManager CHECK " + c.C_Name + " US Active commandpoints = Failed");
					Debug.LogWarning ("DataManager CHECK " + c.CommandActivePoints + " - " + cf.CommandActivePoints);
				}
			}

		}
	}

	void CheckDictionairies(){
		if (FactionManager.control.USFaction.AssaultTeams.Count == FactionManager.control.Factions ["US"].AssaultTeams.Count) {
			Debug.LogWarning ("DataManager CHECK US ASSAULTTEAM = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK US ASSAULTTEAM = Failed");
		}

		if (FactionManager.control.GERMANFaction.AssaultTeams.Count == FactionManager.control.Factions ["GERMANY"].AssaultTeams.Count) {
			Debug.LogWarning ("DataManager CHECK GERMANY ASSAULTTEAM = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK GERMANY ASSAULTTEAM = Failed");
		}

		if (FactionManager.control.SOVIETFaction.AssaultTeams.Count == FactionManager.control.Factions ["SOVIET"].AssaultTeams.Count) {
			Debug.LogWarning ("DataManager CHECK SOVIET ASSAULTTEAM = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK SOVIET ASSAULTTEAM = Failed");
		}

		if (FactionManager.control.USFaction.Characters.Count == FactionManager.control.Factions ["US"].Characters.Count) {
			Debug.LogWarning ("DataManager CHECK US Characters = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK US Characters = Failed");
		}

		if (FactionManager.control.GERMANFaction.Characters.Count == FactionManager.control.Factions ["GERMANY"].Characters.Count) {
			Debug.LogWarning ("DataManager CHECK GERMANY Characters = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK GERMANY Characters = Failed");
		}

		if (FactionManager.control.SOVIETFaction.Characters.Count == FactionManager.control.Factions ["SOVIET"].Characters.Count) {
			Debug.LogWarning ("DataManager CHECK SOVIET Characters = Passed");
		} else {
			Debug.LogWarning ("DataManager CHECK SOVIET Characters = Failed");
		}
	}
}
