using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class ATData {

	public int AT_ID;

	// Owner ID only used for the deploy list
	public int Owner_ID;

	public int deploy_ID;
	// Assault team info
	public string AT_Name;

	//public Texture AT_icon;

	public AssaultTeam.C_Faction Faction;

	public AssaultTeam.AT_Types AT_Type;

	public string Tag;

	public AssaultTeam.AT_Tier AT_Level;

	// command points
	public int CommandPoints;

	//Manpower/Vehicles
	public int Vehicles;

	public int Manpower;

	// activations
	public bool IsActive;

	public bool IsDeployed;

	public bool setForDeploy;

	public bool readyForDeploy;

	public bool IsSavedAndDeployed;

	public int ViewerID;

}
