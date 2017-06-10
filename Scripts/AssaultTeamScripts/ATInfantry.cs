using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class ATInfantry : AssaultTeam {

	public static int infcount = 0;

	public ATInfantry(string faction){
		infcount++;
		Tag = "ARMY1G";
		AT_ID = infcount;
		AT_Name = FactionManager.control.Factions[faction].Tag + "-" + infcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_Infantry");
		AT_Level = AT_Tier.Level_1;
		AT_Type = AT_Types.Infantry;
		CommandPoints = 2;

		if (faction == "US") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/US/Infantry/USINF");
			Faction = C_Faction.US;
		} else if (faction == "GERMANY") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Infantry/21portrait");
			Faction = C_Faction.GERMANY;
		} else if (faction == "SOVIET") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Infantry/28portrait");
			Faction = C_Faction.SOVIET;
		}
	}
}
