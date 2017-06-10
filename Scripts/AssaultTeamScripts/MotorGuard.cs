using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class MotorGuard : AssaultTeam {

	public static int MotorGuardcount = 0;

	public MotorGuard(string sfact){
		MotorGuardcount++;
		Tag = "ARMY1G";
		AT_ID = MotorGuardcount;
		AT_Name = FactionManager.control.Factions[sfact].Tag + "-" + MotorGuardcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_MotorizedGuard");
		AT_Level = AT_Tier.Level_1;
		AT_Type = AT_Types.Motorized_Guard;
		CommandPoints = 1;

		if (sfact == "US") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/US/Infantry/USINF");
			Faction = C_Faction.US;
		} else if (sfact == "GERMANY") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/GERMANY/Infantry/21portrait");
			Faction = C_Faction.GERMANY;
		} else if (sfact == "SOVIET") {
			//C_Image = Resources.Load<Texture> ("Images/Characters/SOVIET/Infantry/28portrait");
			Faction = C_Faction.SOVIET;
		}
	}
}
