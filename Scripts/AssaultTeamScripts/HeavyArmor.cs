using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class HeavyArmor : AssaultTeam {
	public static int HeavyArmorcount = 0;

	public HeavyArmor(string faction){
		HeavyArmorcount++;
		Tag = "ARMOR3";
		AT_ID = HeavyArmorcount;
		AT_Name = FactionManager.control.Factions[faction].Tag + "-" + HeavyArmorcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_HeavyArmor");
		AT_Level = AT_Tier.Level_2;
		AT_Type = AT_Types.Heavy_Armor;
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
