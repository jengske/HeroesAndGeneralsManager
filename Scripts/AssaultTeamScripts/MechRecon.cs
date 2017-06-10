using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class MechRecon : AssaultTeam {

	public static int MechReconcount = 0;

	public MechRecon(string faction){
		MechReconcount++;
		Tag = "ARMY2R";
		AT_ID = MechReconcount;
		AT_Name = FactionManager.control.Factions[faction].Tag + "-" + MechReconcount.ToString() + " " + AT_Type.ToString();
		AT_icon = Resources.Load<Texture> ("Images/Assault-Teams/AssaultTeam_MechanizedRecon");
		AT_Level = AT_Tier.Level_2;
		AT_Type = AT_Types.Mechanized_Recon;
		CommandPoints = 1;
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
