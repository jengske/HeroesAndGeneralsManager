using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class CharacterData {

	// ID
	public int C_ID;
	public int C_DeployID;

	// Naming
	public string C_Name;

	// character image
	//public Texture C_Image;

	// character class
	public Character.C_Type Type;

	// character Rank
	public Character.C_Rank Rank;

	public Character.C_Faction Faction;
	// selection
	public bool IsSelected;

	// squad points
	//public int SquadPoints;
	//public static int MaxSquadPoints;

	// command points
	public int CommandPoints;

	public int CommandActivePoints;

	public bool hasDeployed;
	public bool hasSavedDeploy;


	// character Assault teams Deployed
	//public List<int> AssaultTeamsDeployed;
}
