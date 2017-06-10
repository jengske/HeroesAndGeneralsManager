using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Infantry : Character {
	public static int infCount = 0;

	public Infantry(string faction){
		infCount++;

		//Display = Resources.Load<CharacterHolder> ("Prefabs/CharacterHolder") as CharacterHolder;
		C_ID = infCount;
		C_Name = "Infantry";
		if (faction == "US") {
			C_Image = Resources.Load<Texture> ("Images/Characters/US/Infantry/USINF");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Infantry/21portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Infantry/28portrait");
			Faction = C_Faction.SOVIET;
		}

		Rank = C_Rank.Private;
		Type = C_Type.InfantryMan;
		RankIcon = FactionManager.control.Factions [faction].Ranks [Rank];
		//AssaultTeamsDeployed = new List<AssaultTeam> ();
		//CommandActivePoints = 0;
	}

	// Use this for initialization



}
