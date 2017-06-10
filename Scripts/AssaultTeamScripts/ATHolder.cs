using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class ATHolder : MonoBehaviour {
	public Text Name;
	public RawImage img;
	public Toggle isDeployed;
	public Toggle isGold;
	public bool DeployAT = false;
	public bool active = false;
	public bool DeployView = false;

	//public bool _isGold = false;
	// Use this for initialization
	void Start () {
		

		// disabled by default for multi usage
		//isDeployed.isOn = false;
	}
//	public void OnToggle(bool selected){
//		Debug.Log ("what value we got? " + isDeployed.isOn);
//		_isGold = true;
//	}
	// Update is called once per frame
	void Update () {
		

		//OnToggle (isGold.isOn);
		if(isDeployed.isOn == true && DeployView == false){
			DeployAT = true;
			active = true;
		}else if(isDeployed.isOn == false && DeployView == false){
			DeployAT = false;
			active = false;
		}

		if(active == true){
			isDeployed.isOn = true;
			isDeployed.gameObject.SetActive (false);
			isGold.gameObject.SetActive (false);
			this.gameObject.SetActive (false);
		}else if(active == false){
			isDeployed.isOn = false;
			isDeployed.gameObject.SetActive (true);
			isGold.gameObject.SetActive (true);
		}

		if(DeployView == true){
			isDeployed.gameObject.SetActive(false);
			isGold.gameObject.SetActive (false);
		}
	}
}
