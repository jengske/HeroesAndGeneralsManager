using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class MechInfantry : AssaultTeam {

	public static int Mechinfcount = 0;

	public MechInfantry(string faction){
		Mechinfcount++;
		Tag = "ARMY3G";
		AT_ID = Mechinfcount;
		AT_Name = FactionManager.control.Factions[faction].Tag + "-" + Mechinfcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_MechanizedInfantry");
		AT_Level = AT_Tier.Level_3;
		AT_Type = AT_Types.Mechanized_Infantry;
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
