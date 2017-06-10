using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Tankman : Character {

	public static int tankManCount = 0;

	public Tankman(string faction){
		tankManCount++;

		C_ID = tankManCount;
		C_Name = "TankMan";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/Tanker/USTANK");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Tanker/1portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Tanker/29portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.Private;
		Type = C_Type.TankMan;
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
