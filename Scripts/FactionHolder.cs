using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class FactionHolder : MonoBehaviour {
	// Characters owned
	public Text cCharacters;
	public Text cInfantry;
	public Text cRecon;
	public Text cPara;
	public Text cTankman;
	public Text cPilot;
	public Text cGeneral;

	// Assault teams owned
	public Text atGuard;
	public Text atMotorizedGuard;
	public Text atInfantry;
	public Text atMotorizedInfantry;
	public Text atMechanizedInfantry;

	public Text atRecon;
	public Text atMotorizedRecon;
	public Text atMechanizedRecon;

	public Text atLightArmor;
	public Text atMediumArmor;
	public Text atHeavyArmor;
	public Text atDestroyers;

	public Text atPathfinders;
	public Text atParatroopers;

	public Text atReconFighters;
	public Text atFighters;
	public Text atHeavyFighters;

	// Man and Vehicles amount
	public Text manGuard;
	public Text vehicleGuard;
	public Text manMotorizedGuard;
	public Text vehicleMotorizedGuard;
	public Text manInfantry;
	public Text vehicleInfantry;
	public Text manMotorizedInfantry;
	public Text vehicleMotorizedInfantry;
	public Text manMechanizedInfantry;
	public Text vehicleMechanizedInfantry;

	public Text manRecon;
	public Text vehicleRecon;
	public Text manMotorizedRecon;
	public Text vehicleMotorizedRecon;
	public Text manMechanizedRecon;
	public Text vehicleMechanizedRecon;

	public Text manLightArmor;
	public Text vehicleLightArmor;
	public Text manMediumArmor;
	public Text vehicleMediumArmor;
	public Text manHeavyArmor;
	public Text vehicleHeavyArmor;
	public Text manDestroyers;
	public Text vehicleDestroyers;

	public Text manPathfinders;
	public Text vehiclePathfinders;
	public Text manParatroopers;
	public Text vehicleParatroopers;


	public Text manReconFighters;
	public Text vehicleReconFighters;
	public Text manFighters;
	public Text vehicleFighters;
	public Text manHeavyFighters;
	public Text vehicleHeavyFighters;


	// show ranks
	public Text ranks;
	// flag
	public RawImage Flag;
	// close button X
	public Button Close;

	public bool isActive = false;

	public void OnClose(){
		this.gameObject.SetActive (false);
		this.GetComponent<FactionHolder> ().isActive = false;
	}

}
