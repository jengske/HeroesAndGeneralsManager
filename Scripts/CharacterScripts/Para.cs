using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Para : Character {

	public static int paraCount = 0;

	public Para(string faction){
		paraCount++;

		//Display = Resources.Load<CharacterHolder> ("Prefabs/CharacterHolder") as CharacterHolder;
		C_ID = paraCount;
		C_Name = "Para";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/Para/USPARA");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Para/5portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Para/30portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.Private;
		Type = C_Type.Para;
		//AssaultTeamsDeployed = new List<AssaultTeam> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	

}
