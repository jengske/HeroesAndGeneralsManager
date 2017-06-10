using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Pilot : Character {

	public static int pilotCount = 0;

	public Pilot(string faction){
		pilotCount++;

		//Display = Resources.Load<CharacterHolder> ("Prefabs/CharacterHolder") as CharacterHolder;
		C_ID = pilotCount;
		C_Name = "Tester";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/Pilot/USPIL");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Pilot/22portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Pilot/32portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.Private;
		Type = C_Type.Pilot;
		//AssaultTeamsDeployed = new List<AssaultTeam> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
//	void UIUpdate () {
//		CharPanel.CharacterImage.texture = C_Image;
//		CharPanel.CharacterName.text = C_Name;
//		CharPanel.CharacterFaction.texture = FactionFlag;
//		CharPanel.CharacterRank.texture = RankIcon;
//		CharPanel.CharacterRankName.text = Rank.ToString ();
//	}
}
