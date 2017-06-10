using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class General : Character {
	public static int genCount = 0;

	public General(string faction){
		genCount++;
		//Display = Resources.Load<CharacterHolder> ("Prefabs/CharacterHolder") as CharacterHolder;
		C_ID = genCount;
		C_Name = "General";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/General/USGEN");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/General/26portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/General/132portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.BrigadierGeneral;
		Type = C_Type.General;
		//AssaultTeamsDeployed = new List<AssaultTeam> ();
		setCommandPoints();
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
