using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

[Serializable]
public class Deploydata{
	private DateTime _date;
	public string currentFaction;
	// Deploy System
	// Character
	public int C_DeployID;

	public bool hasSavedDeploy;

	public bool hasDeploy;

	public int CommandActivePoints;

	public int CommandPoints;

	// assaultteam
	public string name;
	public bool IsActive;

	// deploy flow
	public bool setForDeploy;

	public bool readyForDeploy;

	public bool IsDeployed;

	public bool IsSavedAndDeployed;

	public int deployID;

	public int Owner_ID;

	public int ViewerID;

	//public bool isGold;



	public Deploydata(string _name, string _faction, int _C_DeployID, int _deployID, int _Owner_ID, int _ViewerID , bool _hasSavedDeploy, bool _hasDeploy, int _CommandActivePoints, int _CommandPoints, bool _IsActive, bool _setForDeploy, bool _readyForDeploy, bool _IsDeployed, bool _IsSavedAndDeployed){
		_date = DateTime.Now.Date;
		name = _name;

		currentFaction = _faction;
		// Deploy System
		// Character
		C_DeployID = _C_DeployID;

		hasSavedDeploy = _hasSavedDeploy;

		hasDeploy = _hasDeploy;

		CommandActivePoints = _CommandActivePoints;

		CommandPoints = _CommandPoints;

		// assaultteam
		IsActive = _IsActive;

		// deploy flow
		setForDeploy = _setForDeploy;

		readyForDeploy = _readyForDeploy;

		IsDeployed = _IsDeployed;

		IsSavedAndDeployed = _IsSavedAndDeployed;

		deployID = _deployID;

		Owner_ID = _Owner_ID;

		ViewerID = _ViewerID;

		//isGold = _isGold;


		Debug.LogError (_date + ": new deploydata created: " + C_DeployID.ToString());
	}
}
