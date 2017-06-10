using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Recon : Character {

	public static int reconCount = 0;

	public Recon(string faction){
		reconCount++;

		//Display = Resources.Load<CharacterHolder> ("Prefabs/CharacterHolder") as CharacterHolder;
		C_ID = reconCount;
		C_Name = "Recon";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/Recon/USREC");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Recon/10portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Recon/61portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.Private;
		Type = C_Type.Recon;
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
