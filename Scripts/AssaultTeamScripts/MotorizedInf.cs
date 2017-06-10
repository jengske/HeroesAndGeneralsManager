using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class MotorizedInf : AssaultTeam {

	public static int minfcount = 0;

	public MotorizedInf(string faction){
		minfcount++;
		counters.AT_Counter++;
		Tag = "ARMY2G";
		AT_ID = minfcount;
		AT_Name = FactionManager.control.Factions[faction].Tag + "-" + minfcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_MotorizedInfantry");
		AT_Level = AT_Tier.Level_2;
		AT_Type = AT_Types.Motorized_Infantry;
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
