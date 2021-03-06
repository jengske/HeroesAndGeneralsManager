/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// Assault_Team.cs
/// 
/// </summary>
/// 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// these need to be added for file management works
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
[Serializable]
public class AssaultTeam {
	// Character display holder
	[NonSerialized]	public ATHolder CharPanel;

	// ID
	public int AT_ID { get; set; }

	// Assault team info
	public string AT_Name{ get; set; }

	public Texture AT_icon { get; set; }

	public enum C_Faction{US, SOVIET, GERMANY};

	public C_Faction Faction{ get; set; }

	public enum AT_Types
	{
		Guard, 
		Motorized_Guard, 
		Infantry, 
		Motorized_Infantry, 
		Mechanized_Infantry, 
		Recon, Motorized_Recon, 
		Mechanized_Recon, 
		Light_Armor, 
		Medium_Armor,
		MediumTankDestroyer,
		Heavy_Armor, 
		Fighter_Recon, 
		Fighter_Squadron, 
		Heavy_Fighter, 
		Pathfinders, 
		Paratroopers
	}

	public AT_Types AT_Type { get; set; }
		
	public string Tag { get; set; }

	public enum  AT_Tier
	{
		Level_0,
		Level_1,
		Level_2,
		Level_3
	};

	public AT_Tier AT_Level { get; set; }

	// command points
	public int CommandPoints { get; set; }

	//Manpower/Vehicles
	public int Vehicles {get; set;}

	public int Manpower { get; set; }

	// activations
	public bool IsActive { get; set; }

	// deploy flow
	public bool setForDeploy { get; set; }

	public bool readyForDeploy { get; set; }

	public bool IsDeployed { get; set; }

	public bool IsSavedAndDeployed { get; set; }

	public int deployID  {get; set; }

	// Owner ID only used for the deploy list
	public int Owner_ID { get; set; }

	public int ViewerID { get; set; }

	void Awake(){
		//UIUpdate ();
	}

	// Use this for initialization
	void Start () {
		ViewerID = 0;
		Owner_ID = 0;
		IsDeployed = false;
		readyForDeploy = false;
	}

	// Update is called once per frame
	void Update () {
		//UIUpdate ();
	}

	public void Rename(string _newname){
		if (string.IsNullOrEmpty (_newname)) {
			//Debug.LogError ("No name entered");
			return;
		}
		AT_Name = _newname;
	}

	public void Levelup(){

		switch (AT_Level) {
		case AT_Tier.Level_0:
			AT_Level = AT_Tier.Level_1;
			break;
		case AT_Tier.Level_1:
			AT_Level = AT_Tier.Level_2;
			break;
		case AT_Tier.Level_2:
			AT_Level = AT_Tier.Level_3;
			break;
		case AT_Tier.Level_3:
			break;
		}

	}

	public void SwitchType(AT_Types _newtype){
		if (_newtype == AT_Type)
			return;
		
		AT_Type = _newtype;
	}

	void UIUpdate(){
		CharPanel.GetComponent<ATHolder> ().Name.text = "tester";
		CharPanel.GetComponent<ATHolder> ().DeployAT = IsDeployed;

	}
}
